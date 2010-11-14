using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class DomainsInfoBase
	{
		#region Fields

		private int iD;
		private string name;
		private int customerID;
		private string domain;
		private DateTime startDate;
		private DateTime expireDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DomainsInfoBase class.
		/// </summary>
		public DomainsInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the DomainsInfoBase class.
		/// </summary>
		public DomainsInfoBase(string name, int customerID, string domain, DateTime startDate, DateTime expireDate)
		{
			this.name = name;
			this.customerID = customerID;
			this.domain = domain;
			this.startDate = startDate;
			this.expireDate = expireDate;
		}

		/// <summary>
		/// Initializes a new instance of the DomainsInfoBase class.
		/// </summary>
		public DomainsInfoBase(int iD, string name, int customerID, string domain, DateTime startDate, DateTime expireDate)
		{
			this.iD = iD;
			this.name = name;
			this.customerID = customerID;
			this.domain = domain;
			this.startDate = startDate;
			this.expireDate = expireDate;
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
		/// Gets or sets the CustomerID value.
		/// </summary>
		public int CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}

		/// <summary>
		/// Gets or sets the Domain value.
		/// </summary>
		public string Domain
		{
			get { return domain; }
			set { domain = value; }
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
		/// Gets or sets the ExpireDate value.
		/// </summary>
		public DateTime ExpireDate
		{
			get { return expireDate; }
			set { expireDate = value; }
		}

		#endregion
	}
}
