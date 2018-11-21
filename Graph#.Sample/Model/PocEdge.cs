using System;
using System.Diagnostics;
using QuickGraph;

namespace GraphSharp.Sample.Model
{
    [Serializable]
	[DebuggerDisplay( "{Source.ID} -> {Target.ID}" )]
	public class PocEdge : Edge<PocVertex>
	{
	    public string ID { get; private set; }

		public PocEdge( string id, PocVertex source, PocVertex target )
			: base( source, target )
		{
			ID = id;
		}
	}
}