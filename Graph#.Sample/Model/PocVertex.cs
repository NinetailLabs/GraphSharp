using System.Diagnostics;
using System.Xml.Serialization;

namespace GraphSharp.Sample.Model
{
    [DebuggerDisplay("{ID}")]
    public class PocVertex
    {
        public PocVertex()
        {
        }

        public PocVertex(string id, int fontSize)
        {
            ID = id;
            FontSize = fontSize;
        }

        [XmlAttribute]
        public string ID { get; set; }

        [XmlAttribute]
        public int FontSize { get; set; }

        public override string ToString()
        {
            return ID;
        }
    }
}