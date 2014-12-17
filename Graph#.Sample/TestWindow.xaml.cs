using System;
using System.Linq;
using System.Windows;
using GraphSharp.Controls;
using QuickGraph;

namespace GraphSharp.Sample
{
    public partial class TestWindow
    {
        private BidirectionalGraph<string, IEdge<string>> _graph;

        public TestWindow()
        {
            InitializeComponent();
        }

        private void OnNewClick(object sender, RoutedEventArgs e)
        {
            _graph = new BidirectionalGraph<string, IEdge<string>>();

            var random = new Random(DateTime.Now.Millisecond);
            int rnd = random.Next(13) + 2;
            for (int i = 0; i < rnd; i++)
            {
                _graph.AddVertex(i.ToString());
            }

            rnd = random.Next(_graph.VertexCount * 2) + 2;
            for (int i = 0; i < rnd; i++)
            {
                int v1 = random.Next(_graph.VertexCount);
                int v2 = random.Next(_graph.VertexCount);

                string vo1 = _graph.Vertices.ElementAt(v1);
                string vo2 = _graph.Vertices.ElementAt(v2);

                _graph.AddEdge(new Edge<string>(vo1, vo2));
            }

            DataContext = _graph;
        }

        private void OnRelayoutClick(object sender, RoutedEventArgs e)
        {
            Layout.Relayout();
        }

        private void OnAddVertexClick(object sender, RoutedEventArgs e)
        {
            if (_graph == null || _graph.VertexCount >= 100)
                return;

            var rnd = new Random(DateTime.Now.Millisecond);
            int verticesToAdd = Math.Max(_graph.VertexCount / 4, 1);
            var parents = new string[verticesToAdd];
            for (int j = 0; j < verticesToAdd; j++)
            {
                parents[j] = _graph.Vertices.ElementAt(rnd.Next(_graph.VertexCount));
            }
            for (int i = 0; i < verticesToAdd; i++)
            {
                string newVertex;
                do
                {
                    newVertex = rnd.Next(0, _graph.VertexCount + 20) + "_new";
                } while (_graph.ContainsVertex(newVertex));
                _graph.AddVertex(newVertex);

                if (_graph.VertexCount < 2)
                    return;

                _graph.AddEdge(new Edge<string>(parents[i], newVertex));
            }
        }

        private void OnRemoveVertexClick(object sender, RoutedEventArgs e)
        {
            if (_graph == null)
                return;

            if (_graph.VertexCount < 1)
                return;
            var rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10 && _graph.VertexCount > 1; i++)
                _graph.RemoveVertex(_graph.Vertices.ElementAt(rnd.Next(_graph.VertexCount)));
        }

        private void OnRemoveEdgeClick(object sender, RoutedEventArgs e)
        {
            if (_graph == null)
                return;

            if (_graph.EdgeCount < 1)
                return;
            var rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10 && _graph.EdgeCount > 0; i++)
                _graph.RemoveEdge(_graph.Edges.ElementAt(rnd.Next(_graph.EdgeCount)));
        }

        private void OnAddEdgeClick(object sender, RoutedEventArgs e)
        {
            if (_graph == null)
                return;

            if (_graph.VertexCount < 2)
                return;

            var rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                int v1 = rnd.Next(_graph.VertexCount);
                int v2 = rnd.Next(_graph.VertexCount);

                string vo1 = _graph.Vertices.ElementAt(v1);
                string vo2 = _graph.Vertices.ElementAt(v2);

                _graph.AddEdge(new Edge<string>(vo1, vo2));
            }
        }
    }

    public class MyGraphLayout : GraphLayout<string, IEdge<string>, IBidirectionalGraph<string, IEdge<string>>> { }
}