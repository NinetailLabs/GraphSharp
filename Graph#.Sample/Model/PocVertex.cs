using System.Diagnostics;

namespace GraphSharp.Sample.Model
{
    [DebuggerDisplay("{ID}")]
    public class PocVertex
    {
        public PocVertex(string id)
        {
            ID = id;
        }

        public string ID { get; private set; }

        public override string ToString()
        {
            return ID;
        }
    }
}