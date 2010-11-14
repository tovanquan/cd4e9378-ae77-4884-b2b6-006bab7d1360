using System;

namespace thietkeso.Common.Models.Base
{
	[Serializable]
	public class SupporterInfoBase
	{
		#region Fields

		private int iD;
		private string name;
		private string yahoo;
		private string skype;
		private string mail;
		private string mobile;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SupporterInfoBase class.
		/// </summary>
		public SupporterInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the SupporterInfoBase class.
		/// </summary>
		public SupporterInfoBase(string name, string yahoo, string skype, string mail, string mobile)
		{
			this.name = name;
			this.yahoo = yahoo;
			this.skype = skype;
			this.mail = mail;
			this.mobile = mobile;
		}

		/// <summary>
		/// Initializes a new instance of the SupporterInfoBase class.
		/// </summary>
		public SupporterInfoBase(int iD, string name, string yahoo, string skype, string mail, string mobile)
		{
			this.iD = iD;
			this.name = name;
			this.yahoo = yahoo;
			this.skype = skype;
			this.mail = mail;
			this.mobile = mobile;
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
		/// Gets or sets the Yahoo value.
		/// </summary>
		public string Yahoo
		{
			get { return yahoo; }
			set { yahoo = value; }
		}

		/// <summary>
		/// Gets or sets the Skype value.
		/// </summary>
		public string Skype
		{
			get { return skype; }
			set { skype = value; }
		}

		/// <summary>
		/// Gets or sets the Mail value.
		/// </summary>
		public string Mail
		{
			get { return mail; }
			set { mail = value; }
		}

		/// <summary>
		/// Gets or sets the Mobile value.
		/// </summary>
		public string Mobile
		{
			get { return mobile; }
			set { mobile = value; }
		}

		#endregion
	}
}
