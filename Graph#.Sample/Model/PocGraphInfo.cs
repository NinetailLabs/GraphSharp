using System.Xml.Serialization;
using GraphSharp.Serialization;

namespace GraphSharp.Sample.Model
{
    [XmlInclude(typeof(PocVertexInfo))]
    [XmlInclude(typeof(PocVertex))]
    [XmlInclude(typeof(PocEdgeInfo))]
    [XmlInclude(typeof(PocGraph))]
    public class PocGraphInfo : GraphInfo<PocVertex, PocVertexInfo, PocEdge, PocEdgeInfo, PocGraph>
    {

    }

    public class PocVertexInfo : VertexInfo<PocVertex>
    {}

    public class PocEdgeInfo : EdgeInfo<PocEdge>
    {}

}