using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IDomainsService
	{
		/// <summary>
		/// Saves a record to the Domains table.
		/// </summary>
		void Insert(DomainsInfo domainsInfo);

		/// <summary>
		/// Saves a record to the Domains table.
		/// </summary>
		void Update(DomainsInfo domainsInfo);

		/// <summary>
		/// Delete a record from the Domains table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Deletes all records from the Domains table by foreign key value.
		/// </summary>
		void DeleteAllByCustomerID(int customerID);

		/// <summary>
		/// Selects a single record from the Domains table.
		/// </summary>
		DomainsInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Domains table.
		/// </summary>
		CHRTList<DomainsInfo> SelectAll();

		/// <summary>
		/// Selects all records from the Domains table by foreign key value.
		/// </summary>
		CHRTList<DomainsInfo> SelectAllByCustomerID(int customerID);

	}
}
