using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class WebsitesInfoBase
	{
		#region Fields

		private int iD;
		private int customerID;
		private string link;
		private string image;
		private string description;
		private decimal cost;
		private DateTime startDate;
		private DateTime finishDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the WebsitesInfoBase class.
		/// </summary>
		public WebsitesInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the WebsitesInfoBase class.
		/// </summary>
		public WebsitesInfoBase(int customerID, string link, string image, string description, decimal cost, DateTime startDate, DateTime finishDate)
		{
			this.customerID = customerID;
			this.link = link;
			this.image = image;
			this.description = description;
			this.cost = cost;
			this.startDate = startDate;
			this.finishDate = finishDate;
		}

		/// <summary>
		/// Initializes a new instance of the WebsitesInfoBase class.
		/// </summary>
		public WebsitesInfoBase(int iD, int customerID, string link, string image, string description, decimal cost, DateTime startDate, DateTime finishDate)
		{
			this.iD = iD;
			this.customerID = customerID;
			this.link = link;
			this.image = image;
			this.description = description;
			this.cost = cost;
			this.startDate = startDate;
			this.finishDate = finishDate;
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
		/// Gets or sets the CustomerID value.
		/// </summary>
		public int CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}

		/// <summary>
		/// Gets or sets the Link value.
		/// </summary>
		public string Link
		{
			get { return link; }
			set { link = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Cost value.
		/// </summary>
		public decimal Cost
		{
			get { return cost; }
			set { cost = value; }
		}

		/// <summary>
		/// Gets or sets the StartDate value.
		/// </summary>
		public DateTime StartDate
		{
			get { return startDate; }
			set { startDate = value; }
		}

		/// <summary>
		/// Gets or sets the FinishDate value.
		/// </summary>
		public DateTime FinishDate
		{
			get { return finishDate; }
			set { finishDate = value; }
		}

		#endregion
	}
}
