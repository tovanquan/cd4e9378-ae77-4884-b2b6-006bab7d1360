using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class TemplatesInfoBase
	{
		#region Fields

		private int iD;
		private int tempCategoryID;
		private string name;
		private string description;
		private string image;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TemplatesInfoBase class.
		/// </summary>
		public TemplatesInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the TemplatesInfoBase class.
		/// </summary>
		public TemplatesInfoBase(int tempCategoryID, string name, string description, string image)
		{
			this.tempCategoryID = tempCategoryID;
			this.name = name;
			this.description = description;
			this.image = image;
		}

		/// <summary>
		/// Initializes a new instance of the TemplatesInfoBase class.
		/// </summary>
		public TemplatesInfoBase(int iD, int tempCategoryID, string name, string description, string image)
		{
			this.iD = iD;
			this.tempCategoryID = tempCategoryID;
			this.name = name;
			this.description = description;
			this.image = image;
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
		/// Gets or sets the TempCategoryID value.
		/// </summary>
		public int TempCategoryID
		{
			get { return tempCategoryID; }
			set { tempCategoryID = value; }
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

		/// <summary>
		/// Gets or sets the Image value.
		/// </summary>
		public string Image
		{
			get { return image; }
			set { image = value; }
		}

		#endregion
	}
}
