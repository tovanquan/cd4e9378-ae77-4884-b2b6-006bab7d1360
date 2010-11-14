using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class HostingsInfoBase
	{
		#region Fields

		private int iD;
		private int customerID;
		private string package;
		private DateTime startDate;
		private DateTime expireDate;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HostingsInfoBase class.
		/// </summary>
		public HostingsInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the HostingsInfoBase class.
		/// </summary>
		public HostingsInfoBase(int customerID, string package, DateTime startDate, DateTime expireDate)
		{
			this.customerID = customerID;
			this.package = package;
			this.startDate = startDate;
			this.expireDate = expireDate;
		}

		/// <summary>
		/// Initializes a new instance of the HostingsInfoBase class.
		/// </summary>
		public HostingsInfoBase(int iD, int customerID, string package, DateTime startDate, DateTime expireDate)
		{
			this.iD = iD;
			this.customerID = customerID;
			this.package = package;
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
		/// Gets or sets the CustomerID value.
		/// </summary>
		public int CustomerID
		{
			get { return customerID; }
			set { customerID = value; }
		}

		/// <summary>
		/// Gets or sets the Package value.
		/// </summary>
		public string Package
		{
			get { return package; }
			set { package = value; }
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
