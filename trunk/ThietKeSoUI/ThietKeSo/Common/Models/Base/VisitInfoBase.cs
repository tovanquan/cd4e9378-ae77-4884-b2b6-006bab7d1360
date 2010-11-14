using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class VisitInfoBase
	{
		#region Fields

		private int visited;
		private int online;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VisitInfoBase class.
		/// </summary>
		public VisitInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the VisitInfoBase class.
		/// </summary>
		public VisitInfoBase(int visited, int online)
		{
			this.visited = visited;
			this.online = online;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Visited value.
		/// </summary>
		public int Visited
		{
			get { return visited; }
			set { visited = value; }
		}

		/// <summary>
		/// Gets or sets the Online value.
		/// </summary>
		public int Online
		{
			get { return online; }
			set { online = value; }
		}

		#endregion
	}
}
