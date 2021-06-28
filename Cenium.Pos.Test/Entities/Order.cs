using System;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
    [Serializable, XmlRoot("Order")]
    public class Order
    {
        public long OrderId { get; set; }
        public string OrderNo { get; set; }
        public string PrimaryGuestName { get; set; }
        public string RoomNumber { get; set; }
        public string Status { get; set; }
        public string PropertyStatus { get; set; }
        public bool BlockExternalCharges { get; set; }
        public bool IsGroupPaymaster { get; set; }
    }
}
