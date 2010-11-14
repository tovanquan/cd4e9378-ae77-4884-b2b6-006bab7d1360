using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IPartnersService
	{
		/// <summary>
		/// Saves a record to the Partners table.
		/// </summary>
		void Insert(PartnersInfo partnersInfo);

		/// <summary>
		/// Saves a record to the Partners table.
		/// </summary>
		void Update(PartnersInfo partnersInfo);

		/// <summary>
		/// Delete a record from the Partners table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Selects a single record from the Partners table.
		/// </summary>
		PartnersInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Partners table.
		/// </summary>
		CHRTList<PartnersInfo> SelectAll();

	}
}
