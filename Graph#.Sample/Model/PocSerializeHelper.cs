using System.IO;
using System.Xml;
using QuickGraph.Serialization;

namespace GraphSharp.Sample.Model
{
    public static class PocSerializeHelper
    {
        public static PocGraph LoadGraph(string filename)
        {


            using (XmlReader reader = XmlReader.Create(filename))
            {
                //QuickGraph.Serialization.SerializationExtensions.

                var serializer = new GraphMLDeserializer<PocVertex, PocEdge, PocGraph>();

                var pocGraph = new PocGraph();
                serializer.Deserialize(reader, pocGraph, id => new PocVertex(id, 10), (source, target, id) => new PocEdge(id, source, target));
                return pocGraph;
            }

            //            using (var stream = File.OpenRead(filename))
            //            {
            //                return stream.DeserializeFromBinary<PocVertex, PocEdge, PocGraph>();
            //            }
        }

        public static void SaveGraph(PocGraph graph, string filename)
        {
            //            graph.SerializeToBinary()

            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                var serializer = new GraphMLSerializer<PocVertex, PocEdge, PocGraph>();
                serializer.Serialize(writer, graph, v => v.ID, e => e.ID);
            }

            //            using (var stream = File.OpenWrite(filename))
            //            {
            //                graph.SerializeToBinary(stream);
            //            }
        }
    }
}