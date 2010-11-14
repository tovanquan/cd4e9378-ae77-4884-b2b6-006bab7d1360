using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class ArticlesInfoBase
	{
		#region Fields

		private int iD;
		private int categoryID;
		private string title;
		private string summary;
		private string contents;
		private string avatar;
		private string image;
		private string author;
		private DateTime createDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ArticlesInfoBase class.
		/// </summary>
		public ArticlesInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the ArticlesInfoBase class.
		/// </summary>
		public ArticlesInfoBase(int categoryID, string title, string summary, string contents, string avatar, string image, string author, DateTime createDate)
		{
			this.categoryID = categoryID;
			this.title = title;
			this.summary = summary;
			this.contents = contents;
			this.avatar = avatar;
			this.image = image;
			this.author = author;
			this.createDate = createDate;
		}

		/// <summary>
		/// Initializes a new instance of the ArticlesInfoBase class.
		/// </summary>
		public ArticlesInfoBase(int iD, int categoryID, string title, string summary, string contents, string avatar, string image, string author, DateTime createDate)
		{
			this.iD = iD;
			this.categoryID = categoryID;
			this.title = title;
			this.summary = summary;
			this.contents = contents;
			this.avatar = avatar;
			this.image = image;
			this.author = author;
			this.createDate = createDate;
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
		/// Gets or sets the CategoryID value.
		/// </summary>
		public int CategoryID
		{
			get { return categoryID; }
			set { categoryID = value; }
		}

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		/// <summary>
		/// Gets or sets the Summary value.
		/// </summary>
		public string Summary
		{
			get { return summary; }
			set { summary = value; }
		}

		/// <summary>
		/// Gets or sets the Contents value.
		/// </summary>
		public string Contents
		{
			get { return contents; }
			set { contents = value; }
		}

		/// <summary>
		/// Gets or sets the Avatar value.
		/// </summary>
		public string Avatar
		{
			get { return avatar; }
			set { avatar = value; }
		}

		/// <summary>
		/// Gets or sets the Image value.
		/// </summary>
		public string Image
		{
			get { return image; }
			set { image = value; }
		}

		/// <summary>
		/// Gets or sets the Author value.
		/// </summary>
		public string Author
		{
			get { return author; }
			set { author = value; }
		}

		/// <summary>
		/// Gets or sets the CreateDate value.
		/// </summary>
		public DateTime CreateDate
		{
			get { return createDate; }
			set { createDate = value; }
		}

		#endregion
	}
}
