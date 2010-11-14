using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface ITempCategoriesService
	{
		/// <summary>
		/// Saves a record to the TempCategories table.
		/// </summary>
		void Insert(TempCategoriesInfo tempCategoriesInfo);

		/// <summary>
		/// Saves a record to the TempCategories table.
		/// </summary>
		void Update(TempCategoriesInfo tempCategoriesInfo);

		/// <summary>
		/// Delete a record from the TempCategories table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Selects a single record from the TempCategories table.
		/// </summary>
		TempCategoriesInfo Select(int iD);

		/// <summary>
		/// Selects all records from the TempCategories table.
		/// </summary>
		CHRTList<TempCategoriesInfo> SelectAll();

	}
}
