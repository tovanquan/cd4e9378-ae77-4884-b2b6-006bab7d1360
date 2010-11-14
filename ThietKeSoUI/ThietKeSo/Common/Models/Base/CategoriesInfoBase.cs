using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class CategoriesInfoBase
	{
		#region Fields

		private int iD;
		private string name;
		private string description;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CategoriesInfoBase class.
		/// </summary>
		public CategoriesInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CategoriesInfoBase class.
		/// </summary>
		public CategoriesInfoBase(string name, string description)
		{
			this.name = name;
			this.description = description;
		}

		/// <summary>
		/// Initializes a new instance of the CategoriesInfoBase class.
		/// </summary>
		public CategoriesInfoBase(int iD, string name, string description)
		{
			this.iD = iD;
			this.name = name;
			this.description = description;
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		#endregion
	}
}
