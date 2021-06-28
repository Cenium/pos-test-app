using System;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
    [Serializable, XmlRoot("result")]
    public class PropertyRespons : GeneralRespons
    {
        public PropertySetup[] Items { get; set; }
    }
}
