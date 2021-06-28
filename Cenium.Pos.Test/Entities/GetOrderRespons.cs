using System;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
    [Serializable, XmlRoot("result")]
    public class GetOrderRespons : GeneralRespons
    {

        public Order[] Items { get; set; }

    }
}
