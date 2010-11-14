using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class CustomersInfoBase
	{
		#region Fields

		private int iD;
		private string name;
		private string address;
		private string mobile;
		private string email;
		private string note;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CustomersInfoBase class.
		/// </summary>
		public CustomersInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CustomersInfoBase class.
		/// </summary>
		public CustomersInfoBase(string name, string address, string mobile, string email, string note)
		{
			this.name = name;
			this.address = address;
			this.mobile = mobile;
			this.email = email;
			this.note = note;
		}

		/// <summary>
		/// Initializes a new instance of the CustomersInfoBase class.
		/// </summary>
		public CustomersInfoBase(int iD, string name, string address, string mobile, string email, string note)
		{
			this.iD = iD;
			this.name = name;
			this.address = address;
			this.mobile = mobile;
			this.email = email;
			this.note = note;
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
		/// Gets or sets the Address value.
		/// </summary>
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		/// <summary>
		/// Gets or sets the Mobile value.
		/// </summary>
		public string Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Note value.
		/// </summary>
		public string Note
		{
			get { return note; }
			set { note = value; }
		}

		#endregion
	}
}
