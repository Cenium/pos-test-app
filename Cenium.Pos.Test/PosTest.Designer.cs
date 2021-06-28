
namespace Cenium.Pos.Test
{
    partial class PosTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.txtCCURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lstOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboGetFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGetProperties = new System.Windows.Forms.Button();
            this.cboProperties = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCasherId = new System.Windows.Forms.TextBox();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCashierName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTerminalId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtItemDesc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(213, 274);
            this.btnGetOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(184, 32);
            this.btnGetOrders.TabIndex = 0;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Location = new System.Drawing.Point(841, 671);
            this.btnCreateTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Size = new System.Drawing.Size(184, 32);
            this.btnCreateTransaction.TabIndex = 1;
            this.btnCreateTransaction.Text = "Create Transaction";
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            this.btnCreateTransaction.Click += new System.EventHandler(this.btnCreateTransaction_Click);
            // 
            // txtCCURL
            // 
            this.txtCCURL.Location = new System.Drawing.Point(211, 12);
            this.txtCCURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCCURL.Name = "txtCCURL";
            this.txtCCURL.Size = new System.Drawing.Size(325, 22);
            this.txtCCURL.TabIndex = 4;
            this.txtCCURL.Text = "http://hotel-california.com/ef";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gateway Username :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gateway Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(211, 39);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(325, 22);
            this.txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 66);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(325, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // lstOrders
            // 
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstOrders.FullRowSelect = true;
            this.lstOrders.HideSelection = false;
            this.lstOrders.HoverSelection = true;
            this.lstOrders.Location = new System.Drawing.Point(23, 314);
            this.lstOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOrders.MultiSelect = false;
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(1033, 190);
            this.lstOrders.TabIndex = 9;
            this.lstOrders.UseCompatibleStateImageBehavior = false;
            this.lstOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Guest Name";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Room No";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "OrderNo";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Is Paymaster";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Block for Charges";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 125;
            // 
            // cboGetFilter
            // 
            this.cboGetFilter.FormattingEnabled = true;
            this.cboGetFilter.Items.AddRange(new object[] {
            "Room Number",
            "Reservation Number",
            "Primary Guest Name",
            "Group Name"});
            this.cboGetFilter.Location = new System.Drawing.Point(213, 209);
            this.cboGetFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGetFilter.Name = "cboGetFilter";
            this.cboGetFilter.Size = new System.Drawing.Size(325, 24);
            this.cboGetFilter.TabIndex = 10;
            this.cboGetFilter.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Get Orders Filter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(213, 242);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(325, 22);
            this.txtFilter.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(548, 32);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 274);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // btnGetProperties
            // 
            this.btnGetProperties.Location = new System.Drawing.Point(211, 98);
            this.btnGetProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetProperties.Name = "btnGetProperties";
            this.btnGetProperties.Size = new System.Drawing.Size(184, 32);
            this.btnGetProperties.TabIndex = 15;
            this.btnGetProperties.Text = "Get Properties";
            this.btnGetProperties.UseVisualStyleBackColor = true;
            this.btnGetProperties.Click += new System.EventHandler(this.btnGetProperties_Click);
            // 
            // cboProperties
            // 
            this.cboProperties.FormattingEnabled = true;
            this.cboProperties.Items.AddRange(new object[] {
            "Room Number",
            "Reservation Number",
            "Primary Guest Name",
            "Group Name"});
            this.cboProperties.Location = new System.Drawing.Point(211, 138);
            this.cboProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProperties.Name = "cboProperties";
            this.cboProperties.Size = new System.Drawing.Size(325, 24);
            this.cboProperties.TabIndex = 16;
            this.cboProperties.Text = "Proprety Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select Property";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cenium Core Gateway URL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 544);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "CashierId:";
            // 
            // txtCasherId
            // 
            this.txtCasherId.Location = new System.Drawing.Point(192, 564);
            this.txtCasherId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCasherId.Name = "txtCasherId";
            this.txtCasherId.Size = new System.Drawing.Size(125, 22);
            this.txtCasherId.TabIndex = 20;
            this.txtCasherId.Text = "1";
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Location = new System.Drawing.Point(57, 564);
            this.txtTransactionId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(125, 22);
            this.txtTransactionId.TabIndex = 22;
            this.txtTransactionId.Text = "123";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 544);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "TransactionId:";
            // 
            // txtCashierName
            // 
            this.txtCashierName.Location = new System.Drawing.Point(327, 564);
            this.txtCashierName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCashierName.Name = "txtCashierName";
            this.txtCashierName.Size = new System.Drawing.Size(125, 22);
            this.txtCashierName.TabIndex = 24;
            this.txtCashierName.Text = "Cashier 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 544);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cashier Name:";
            // 
            // txtTerminalId
            // 
            this.txtTerminalId.Location = new System.Drawing.Point(461, 564);
            this.txtTerminalId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTerminalId.Name = "txtTerminalId";
            this.txtTerminalId.Size = new System.Drawing.Size(125, 22);
            this.txtTerminalId.TabIndex = 26;
            this.txtTerminalId.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 544);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "TerminalId";
            // 
            // txtStoreId
            // 
            this.txtStoreId.Location = new System.Drawing.Point(596, 564);
            this.txtStoreId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(125, 22);
            this.txtStoreId.TabIndex = 28;
            this.txtStoreId.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(592, 544);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "StoreId";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(731, 564);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(125, 22);
            this.txtStoreName.TabIndex = 30;
            this.txtStoreName.Text = "The Pub";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(727, 544);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Store Name";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(596, 633);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(125, 22);
            this.txtUnitPrice.TabIndex = 40;
            this.txtUnitPrice.Text = "20";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(592, 613);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Unit Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(461, 633);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(125, 22);
            this.txtQuantity.TabIndex = 38;
            this.txtQuantity.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(461, 613);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Quantity";
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.Location = new System.Drawing.Point(327, 633);
            this.txtItemDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.Size = new System.Drawing.Size(125, 22);
            this.txtItemDesc.TabIndex = 36;
            this.txtItemDesc.Text = "Soda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 613);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Desc";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(57, 633);
            this.txtItemId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(125, 22);
            this.txtItemId.TabIndex = 34;
            this.txtItemId.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(51, 613);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "ItemId";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(192, 633);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(125, 22);
            this.txtItemName.TabIndex = 32;
            this.txtItemName.Text = "Pepsi Max";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(188, 613);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 519);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "WebTransactionHeader";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 594);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 17);
            this.label21.TabIndex = 44;
            this.label21.Text = "WebTransactionLine";
            // 
            // PosTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 718);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtItemDesc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStoreId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTerminalId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCashierName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTransactionId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCasherId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboProperties);
            this.Controls.Add(this.btnGetProperties);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboGetFilter);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCCURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateTransaction);
            this.Controls.Add(this.btnGetOrders);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PosTest";
            this.Text = "Pos Test App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.TextBox txtCCURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ListView lstOrders;
        private System.Windows.Forms.ComboBox cboGetFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnGetProperties;
        private System.Windows.Forms.ComboBox cboProperties;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCasherId;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCashierName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTerminalId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtItemDesc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

