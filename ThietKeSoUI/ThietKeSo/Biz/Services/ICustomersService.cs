using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface ICustomersService
	{
		/// <summary>
		/// Saves a record to the Customers table.
		/// </summary>
		void Insert(CustomersInfo customersInfo);

		/// <summary>
		/// Saves a record to the Customers table.
		/// </summary>
		void Update(CustomersInfo customersInfo);

		/// <summary>
		/// Delete a record from the Customers table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Selects a single record from the Customers table.
		/// </summary>
		CustomersInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Customers table.
		/// </summary>
		CHRTList<CustomersInfo> SelectAll();

	}
}
