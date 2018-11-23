using System;
using System.ComponentModel;
using GraphSharp.Sample.Model;

namespace GraphSharp.Sample.ViewModel
{
    public class GraphLayoutViewModel : INotifyPropertyChanged
	{
		private string _layoutAlgorithmType;
		private PocGraph _graph;

	    public string LayoutAlgorithmType
		{
	        get
	        {
	            return _layoutAlgorithmType;
	        }
			set
			{
				if (value != _layoutAlgorithmType)
				{
					_layoutAlgorithmType = value;
					NotifyChanged("LayoutAlgorithmType");
				}
			}
		}

		public PocGraph Graph
		{
			get { return _graph; }
			set
			{
				if (value != _graph)
				{
					_graph = value;
					NotifyChanged("Graph");
				}
			}
		}

	    public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}