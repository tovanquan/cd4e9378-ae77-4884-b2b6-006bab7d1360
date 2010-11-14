using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface ITemplatesService
	{
		/// <summary>
		/// Saves a record to the Templates table.
		/// </summary>
		void Insert(TemplatesInfo templatesInfo);

		/// <summary>
		/// Saves a record to the Templates table.
		/// </summary>
		void Update(TemplatesInfo templatesInfo);

		/// <summary>
		/// Delete a record from the Templates table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Deletes all records from the Templates table by foreign key value.
		/// </summary>
		void DeleteAllByTempCategoryID(int tempCategoryID);

		/// <summary>
		/// Selects a single record from the Templates table.
		/// </summary>
		TemplatesInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Templates table.
		/// </summary>
		CHRTList<TemplatesInfo> SelectAll();

		/// <summary>
		/// Selects all records from the Templates table by foreign key value.
		/// </summary>
		CHRTList<TemplatesInfo> SelectAllByTempCategoryID(int tempCategoryID);

	}
}
