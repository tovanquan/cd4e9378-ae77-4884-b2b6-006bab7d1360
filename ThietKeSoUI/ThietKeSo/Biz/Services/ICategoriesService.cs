using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface ICategoriesService
	{
		/// <summary>
		/// Saves a record to the Categories table.
		/// </summary>
		void Insert(CategoriesInfo categoriesInfo);

		/// <summary>
		/// Saves a record to the Categories table.
		/// </summary>
		void Update(CategoriesInfo categoriesInfo);

		/// <summary>
		/// Delete a record from the Categories table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Selects a single record from the Categories table.
		/// </summary>
		CategoriesInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Categories table.
		/// </summary>
		CHRTList<CategoriesInfo> SelectAll();

	}
}
