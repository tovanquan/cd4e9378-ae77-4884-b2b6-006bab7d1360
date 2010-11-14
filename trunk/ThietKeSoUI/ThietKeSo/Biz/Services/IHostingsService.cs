using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IHostingsService
	{
		/// <summary>
		/// Saves a record to the Hostings table.
		/// </summary>
		void Insert(HostingsInfo hostingsInfo);

		/// <summary>
		/// Saves a record to the Hostings table.
		/// </summary>
		void Update(HostingsInfo hostingsInfo);

		/// <summary>
		/// Delete a record from the Hostings table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Deletes all records from the Hostings table by foreign key value.
		/// </summary>
		void DeleteAllByCustomerID(int customerID);

		/// <summary>
		/// Selects a single record from the Hostings table.
		/// </summary>
		HostingsInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Hostings table.
		/// </summary>
		CHRTList<HostingsInfo> SelectAll();

		/// <summary>
		/// Selects all records from the Hostings table by foreign key value.
		/// </summary>
		CHRTList<HostingsInfo> SelectAllByCustomerID(int customerID);

	}
}
