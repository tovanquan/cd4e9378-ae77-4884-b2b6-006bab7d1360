using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface ISupporterService
	{
		/// <summary>
		/// Saves a record to the Supporter table.
		/// </summary>
		void Insert(SupporterInfo supporterInfo);

		/// <summary>
		/// Saves a record to the Supporter table.
		/// </summary>
		void Update(SupporterInfo supporterInfo);

		/// <summary>
		/// Delete a record from the Supporter table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Selects a single record from the Supporter table.
		/// </summary>
		SupporterInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Supporter table.
		/// </summary>
		CHRTList<SupporterInfo> SelectAll();

	}
}
