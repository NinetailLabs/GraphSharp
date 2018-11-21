using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GraphSharp.Controls;
using GraphSharp.Sample.Model;
using GraphSharp.Serialization;

namespace GraphSharp.Sample.ViewModel
{
    public class PocGraphLayout : GraphLayout<PocVertex, PocEdge, PocGraph>
    {
        public static readonly DependencyProperty CommandsProperty = DependencyProperty.Register(
            nameof(Commands), typeof(GraphLayoutCommand), typeof(PocGraphLayout), new PropertyMetadata(default(GraphLayoutCommand), CommandsChangedCallback));

        private static void CommandsChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            GraphLayoutCommand command = (GraphLayoutCommand)e.NewValue;
            if (command == GraphLayoutCommand.Save)
            {
                PocGraphLayout g = d as PocGraphLayout;
                g.SaveGraphInfo();
                g.Commands = GraphLayoutCommand.None;
            }
        }

        private void SaveGraphInfo()
        {
            GraphInfo = GraphInfo<PocVertex, PocVertexInfo, PocEdge, PocEdgeInfo, PocGraph>.Create<PocGraphInfo>(this);
        }

        public GraphLayoutCommand Commands
        {
            get { return (GraphLayoutCommand) GetValue(CommandsProperty); }
            set { SetValue(CommandsProperty, value); }
        }

        public static readonly DependencyProperty GraphInfoProperty = DependencyProperty.Register(
            nameof(GraphInfo), typeof(PocGraphInfo), typeof(PocGraphLayout), new PropertyMetadata(default(PocGraphInfo), GraphInfoChangedCallback));

        private static void GraphInfoChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PocGraphLayout layout = d as PocGraphLayout;
            layout.AddGraph(e.NewValue as PocGraphInfo);
        }

        public PocGraphInfo GraphInfo
        {
            get { return (PocGraphInfo) GetValue(GraphInfoProperty); }
            set { SetValue(GraphInfoProperty, value); }
        }


        protected void AddGraph(PocGraphInfo graphInfo)
        {
            LayoutStates.Clear();

            if (graphInfo == null)
            {
                return;
            }

            HighlightAlgorithm?.ResetHighlight();

            RemoveAllGraphElement();

            Children.Clear();


            Dictionary<int, PocVertex> vertexControlsById = new Dictionary<int, PocVertex>(); 
            foreach (VertexInfo<PocVertex> info in graphInfo.Verteces.OfType<VertexInfo<PocVertex>>())
            {
                AddVertexControl(info);
                vertexControlsById.Add(info.ID, info.Vertex);
            }

            int i = 0;
            foreach (EdgeInfo<PocEdge> info in graphInfo.Edges.OfType<EdgeInfo<PocEdge>>())
            {
                PocVertex source = vertexControlsById[info.SourceID];
                PocVertex target = vertexControlsById[info.TargetID];

                CreateEdgeControl(new PocEdge(i.ToString(), source, target));
                i++;
            }
        }


        protected virtual void AddEdgeControl(PocEdge edge)
        {
            var edgeControl = new EdgeControl
            {
                Edge = edge,
                DataContext = edge
            };
            //var edgeControl = _edgePool.GetObject();
            //edgeControl.Edge = edge;
            EdgeControls[edge] = edgeControl;

            //set the Source and the Target
            edgeControl.Source = VertexControls[edge.Source];
            edgeControl.Target = VertexControls[edge.Target];

            if (ActualLayoutMode == Algorithms.Layout.LayoutMode.Simple)
                Children.Insert(0, edgeControl);
            else
                Children.Add(edgeControl);
            SetHighlightProperties(edge, edgeControl);
            //RunCreationTransition(edgeControl);
        }


        protected void AddVertexControl(VertexInfo<PocVertex> vertexInfo)
        {
            VertexControl presenter;
            var compoundGraph = Graph as ICompoundGraph<PocVertex, PocEdge>;

            if (IsCompoundMode && compoundGraph != null && compoundGraph.IsCompoundVertex(vertexInfo.Vertex))
            {
                var compoundPresenter = new CompoundVertexControl
                {
                    Vertex = vertexInfo.Vertex,
                    DataContext = vertexInfo.Vertex,
                };
                //compoundPresenter.Expanded += CompoundVertexControl_ExpandedOrCollapsed;
                //compoundPresenter.Collapsed += CompoundVertexControl_ExpandedOrCollapsed;
                presenter = compoundPresenter;
            }
            else
            {
                // Create the Control of the vertex
                presenter = new VertexControl
                {
                    Vertex = vertexInfo.Vertex,
                    DataContext = vertexInfo.Vertex,
                };
            }

            VertexControls[vertexInfo.Vertex] = presenter;
            presenter.RootCanvas = this;

            if (IsCompoundMode && compoundGraph != null && compoundGraph.IsChildVertex(vertexInfo.Vertex))
            {
                var parent = compoundGraph.GetParent(vertexInfo.Vertex);
                var parentControl = GetOrCreateVertexControl(parent) as CompoundVertexControl;

                parentControl.Vertices.Add(presenter);
            }
            else
            {
                //add the presenter to the GraphLayout
                Children.Add(presenter);
            }

            SetX(presenter, vertexInfo.X);
            SetY(presenter, vertexInfo.Y);

            //Measuring & Arrange
            presenter.InvalidateMeasure();
            SetHighlightProperties(vertexInfo.Vertex, presenter);
            //RunCreationTransition(presenter);

            return;
        }
    }
}