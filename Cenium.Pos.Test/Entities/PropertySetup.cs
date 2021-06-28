using System;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
    [Serializable, XmlRoot("PropertySetup")]
    public class PropertySetup
    {
        public long PropertySetupId { get; set; }
        public long PropertyContextId { get; set; }
        public bool SplitSaleLines { get; set; }
        public int DefaultItemId { get; set; }
        public string AllowPaymentToStatus { get; set; }
        public PropertyContext PropertyContext { get; set; }
    }
}