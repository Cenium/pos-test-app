using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
   // [Serializable, XmlRoot("WebTransactionHeader")]
    public class WebTransactionHeader
    {
        public DateTime TransactionDate { get; set; }
        public string ExternalTransactionId { get; set; }
        public string ExternalCashierId { get; set; }
        public string ExternalCashierName { get; set; }
        public string ExternalTerminalId { get; set; }
        public string ExternalStoreId { get; set; }
        public string ExternalStoreName { get; set; }
        public long OrderId { get; set; }
        public long PropertyContextId { get; set; }
        public List<WebTransactionLine> WebTransactionLines { get; set; }

    }
}