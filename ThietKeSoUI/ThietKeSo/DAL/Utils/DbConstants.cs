namespace thietkeso.DAL.Utils
{
	public class DbConstants
	{
		public struct ARTICLES
		{
			public const string ID = "ID";
			public const string CATEGORYID = "CategoryID";
			public const string TITLE = "Title";
			public const string SUMMARY = "Summary";
			public const string CONTENTS = "Contents";
			public const string AVATAR = "Avatar";
			public const string IMAGE = "Image";
			public const string AUTHOR = "Author";
			public const string CREATEDATE = "CreateDate";
		}
		public struct CATEGORIES
		{
			public const string ID = "ID";
			public const string NAME = "Name";
			public const string DESCRIPTION = "Description";
		}
		public struct CUSTOMERS
		{
			public const string ID = "ID";
			public const string NAME = "Name";
			public const string ADDRESS = "Address";
			public const string MOBILE = "Mobile";
			public const string EMAIL = "Email";
			public const string NOTE = "Note";
		}
		public struct DOMAINS
		{
			public const string ID = "ID";
			public const string NAME = "Name";
			public const string CUSTOMERID = "CustomerID";
			public const string DOMAIN = "Domain";
			public const string STARTDATE = "StartDate";
			public const string EXPIREDATE = "ExpireDate";
		}
		public struct HOSTINGS
		{
			public const string ID = "ID";
			public const string CUSTOMERID = "CustomerID";
			public const string PACKAGE = "Package";
			public const string STARTDATE = "StartDate";
			public const string EXPIREDATE = "ExpireDate";
		}
		public struct PARTNERS
		{
			public const string ID = "ID";
			public const string NAME = "Name";
			public const string LOGO = "Logo";
		}
		public struct SUPPORTER
		{
			public const string ID = "ID";
			public const string NAME = "Name";
			public const string YAHOO = "Yahoo";
			public const string SKYPE = "Skype";
			public const string MAIL = "Mail";
			public const string MOBILE = "Mobile";
		}
		public struct TEMPCATEGORIES
		{
			public const string ID = "ID";
			public const string NAME = "Name";
			public const string DESCRIPTION = "Description";
		}
		public struct TEMPLATES
		{
			public const string ID = "ID";
			public const string TEMPCATEGORYID = "TempCategoryID";
			public const string NAME = "Name";
			public const string DESCRIPTION = "Description";
			public const string IMAGE = "Image";
		}
		public struct USERS
		{
			public const string ID = "ID";
			public const string USERNAME = "Username";
			public const string PASSWORD = "Password";
			public const string NAME = "Name";
			public const string MOBILE = "Mobile";
			public const string EMAIL = "Email";
			public const string POSISION = "Posision";
			public const string NOTE = "Note";
		}
		public struct VISIT
		{
			public const string VISITED = "Visited";
			public const string ONLINE = "Online";
		}
		public struct WEBSITES
		{
			public const string ID = "ID";
			public const string CUSTOMERID = "CustomerID";
			public const string LINK = "Link";
			public const string IMAGE = "Image";
			public const string DESCRIPTION = "Description";
			public const string COST = "Cost";
			public const string STARTDATE = "StartDate";
			public const string FINISHDATE = "FinishDate";
		}
	}
}
