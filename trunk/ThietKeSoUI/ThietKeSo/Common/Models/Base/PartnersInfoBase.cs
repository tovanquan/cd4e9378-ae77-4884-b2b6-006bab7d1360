using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class PartnersInfoBase
	{
		#region Fields

		private int iD;
		private string name;
		private string logo;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PartnersInfoBase class.
		/// </summary>
		public PartnersInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the PartnersInfoBase class.
		/// </summary>
		public PartnersInfoBase(string name, string logo)
		{
			this.name = name;
			this.logo = logo;
		}

		/// <summary>
		/// Initializes a new instance of the PartnersInfoBase class.
		/// </summary>
		public PartnersInfoBase(int iD, string name, string logo)
		{
			this.iD = iD;
			this.name = name;
			this.logo = logo;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the ID value.
		/// </summary>
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Logo value.
		/// </summary>
		public string Logo
		{
			get { return logo; }
			set { logo = value; }
		}

		#endregion
	}
}
