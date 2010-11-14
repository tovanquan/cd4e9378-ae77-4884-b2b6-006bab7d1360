using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IWebsitesService
	{
		/// <summary>
		/// Saves a record to the Websites table.
		/// </summary>
		void Insert(WebsitesInfo websitesInfo);

		/// <summary>
		/// Saves a record to the Websites table.
		/// </summary>
		void Update(WebsitesInfo websitesInfo);

		/// <summary>
		/// Delete a record from the Websites table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Deletes all records from the Websites table by foreign key value.
		/// </summary>
		void DeleteAllByCustomerID(int customerID);

		/// <summary>
		/// Selects a single record from the Websites table.
		/// </summary>
		WebsitesInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Websites table.
		/// </summary>
		CHRTList<WebsitesInfo> SelectAll();

		/// <summary>
		/// Selects all records from the Websites table by foreign key value.
		/// </summary>
		CHRTList<WebsitesInfo> SelectAllByCustomerID(int customerID);

	}
}
