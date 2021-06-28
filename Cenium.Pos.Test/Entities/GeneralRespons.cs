using System;
using System.Xml.Serialization;

namespace Cenium.Pos.Test
{
    [Serializable, XmlRoot("result")]
    public class GeneralRespons
    {
        public long TotalCount { get; set; }
        public long ResultCount { get; set; }
        public long PageSize { get; set; }
        public long Offset { get; set; }
        public string ErrorId { get; set; }
        public string ErrorMessage { get; set; }

    }
}
