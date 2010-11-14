using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class UsersInfoBase
	{
		#region Fields

		private int iD;
		private string username;
		private string password;
		private string name;
		private string mobile;
		private string email;
		private string posision;
		private string note;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase(string username, string password, string name, string mobile, string email, string posision, string note)
		{
			this.username = username;
			this.password = password;
			this.name = name;
			this.mobile = mobile;
			this.email = email;
			this.posision = posision;
			this.note = note;
		}

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase(int iD, string username, string password, string name, string mobile, string email, string posision, string note)
		{
			this.iD = iD;
			this.username = username;
			this.password = password;
			this.name = name;
			this.mobile = mobile;
			this.email = email;
			this.posision = posision;
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
		/// Gets or sets the Username value.
		/// </summary>
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		/// <summary>
		/// Gets or sets the Password value.
		/// </summary>
		public string Password
		{
			get { return password; }
			set { password = value; }
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
		/// Gets or sets the Posision value.
		/// </summary>
		public string Posision
		{
			get { return posision; }
			set { posision = value; }
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
