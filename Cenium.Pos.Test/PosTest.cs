using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cenium.Pos.Test
{
    public partial class PosTest : Form
    {
        List<WebTransactionLine> _webTransactionLines = new List<WebTransactionLine>();

        public PosTest()
        {
            InitializeComponent();
        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            var request = "/POS/WEB/";
            PropertyContext p = cboProperties.Items[cboProperties.SelectedIndex] as PropertyContext;
            var propertyContextId = p.PropertyContextId;

            switch (cboGetFilter.SelectedItem)
            {
                case "Room Number":
                    request += $"GetOrdersAndGroupsByRoomNumber/{propertyContextId}/{txtFilter.Text}";
                    break;
                case "Reservation Number":
                    request += $"GetOrdersWithFilter/{propertyContextId}/{txtFilter.Text}";
                    break;
                case "Primary Guest Name":
                case "Group Name":
                    request += $"GetOrdersAndGroupsByName/{propertyContextId}/{txtFilter.Text}";
                    break;
                default:
                    throw new Exception();
            }

            var client = Connect(txtUsername.Text, txtPassword.Text);
            var t = Task.Run(() => SendGetRequest(client, request));
            t.Wait();


            var test = t.Result;
            var json = test.Content.ReadAsStringAsync().Result;
            richTextBox1.Text = PrettyJson(json);

            var obj = JsonSerializer.Deserialize<GetOrderRespons>(json);
            ListResult(obj);
        }

        private void ListResult(GetOrderRespons resultingMessage)
        {
            lstOrders.Items.Clear() ;
            foreach(var order in resultingMessage.Items)
            {
                var lv = new ListViewItem(order.PrimaryGuestName);
                lv.SubItems.Add(order.RoomNumber);
                lv.SubItems.Add(order.OrderNo);
                lv.SubItems.Add(order.IsGroupPaymaster.ToString());
                lv.SubItems.Add(order.BlockExternalCharges.ToString());
                lv.SubItems.Add(order.Status);
                lv.Tag = order.OrderId;

                lstOrders.Items.Add(lv);
            }
        }

        private async Task<HttpResponseMessage> SendGetRequest(HttpClient client, string request)
        {
            //setup reusable http client
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, txtCCURL.Text + request);
            var result = await client.SendAsync(requestMessage);
            return result;
        }
        private async Task<HttpResponseMessage> PostAsJson(HttpClient client, string request, WebTransactionHeader transaction)
        {

            var result = await client.PostAsJsonAsync(txtCCURL.Text + request, transaction);
            return result;
        }
        private void btnGetProperties_Click(object sender, EventArgs e)
        {

            var client = Connect(txtUsername.Text, txtPassword.Text);
            var request = "/POS/Web/GetProperties";
            var t = Task.Run(() => SendGetRequest(client, request));
            t.Wait();


            var test = t.Result;
            var json = test.Content.ReadAsStringAsync().Result;
            richTextBox1.Text = PrettyJson(json);

            var resultingMessage = JsonSerializer.Deserialize<PropertyRespons>(json);
            ListProperties(resultingMessage);
        }

        private void ListProperties(PropertyRespons resultingMessage)
        {
            cboProperties.Items.Clear();
            cboProperties.ValueMember = "PropertyContextId";
            cboProperties.DisplayMember = "Name";
            foreach (var prop in resultingMessage.Items)
            {
                cboProperties.Items.Add(prop.PropertyContext);

            }
            cboProperties.SelectedIndex = 0;
        }

        public HttpClient Connect(string username, string password)
        {
            var efInstance = txtCCURL.Text;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(txtCCURL.Text);
            var byteArray = Encoding.ASCII.GetBytes($"{username}:{password}");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            //Log.Instance.Debug($"Connection to client", client);
            return client;
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            PropertyContext p = cboProperties.Items[cboProperties.SelectedIndex] as PropertyContext;
            var propertyContextId = p.PropertyContextId;
            var transaction = new WebTransactionHeader();
            transaction.TransactionDate = DateTime.Now;
            transaction.ExternalTransactionId = txtTransactionId.Text;
            transaction.ExternalCashierId = txtCasherId.Text;
            transaction.ExternalCashierName = txtCashierName.Text;
            transaction.ExternalTerminalId =txtTerminalId.Text;
            transaction.ExternalStoreId = txtStoreId.Text;
            transaction.ExternalStoreName = txtStoreName.Text;
            transaction.OrderId = (long)lstOrders.SelectedItems[0].Tag;
            transaction.PropertyContextId = propertyContextId;
            //            transaction.PaymentMethodName = "Cash";

            var transLine = new WebTransactionLine() { ExternalItemId = txtItemId.Text, ExternalItemName = txtItemName.Text, ExternalItemDescription = txtItemDesc.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text), Quantity = int.Parse(txtQuantity.Text), UnitOfMeasureCode = "1", UnitOfMeasureName = "boks", UnitPriceExcludingTax = 0, TaxAmount = 0, TaxCode = "", TaxPercentage = 0 };

            transaction.WebTransactionLines = new List<WebTransactionLine>();
            transaction.WebTransactionLines.Add(transLine);




            var request = "/POS/Web/CreateTransaction";
            var client = Connect(txtUsername.Text, txtPassword.Text);
            var t = Task.Run(() => PostAsJson(client, request, transaction));
            t.Wait();


            var test = t.Result;
            var xml1 = test.Content.ReadAsStringAsync().Result;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(transaction);
            richTextBox1.Text = PrettyJson(json);
            if (test.IsSuccessStatusCode)
            {
                MessageBox.Show("Posted Successfully!");
            }
            else
            {
                MessageBox.Show(test.StatusCode.ToString());
            }


        }

        public string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    var transLine = new WebTransactionLine() { ExternalItemId = "1", ExternalItemName = "Pepsi", UnitPrice = 20, Quantity = 1, UnitOfMeasureCode = "1", UnitOfMeasureName = "boks", UnitPriceExcludingTax = 20, TaxAmount = 2, TaxCode = "10", TaxPercentage = 10 };
        //    _webTransactionLines.Add(transLine);
        //    grdWebTransactionLine.DataSource = _webTransactionLines;
        //}
    }
}
