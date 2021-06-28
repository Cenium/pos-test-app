using System;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
    [Serializable, XmlRoot("PropertyContext")]
    public class PropertyContext
    {
        public long PropertyContextId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TimeZoneId { get; set; }
        public bool? IsEnabled { get; set; }
    }
}