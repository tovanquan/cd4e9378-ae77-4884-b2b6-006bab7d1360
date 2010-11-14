using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IArticlesService
	{
		/// <summary>
		/// Saves a record to the Articles table.
		/// </summary>
		void Insert(ArticlesInfo articlesInfo);

		/// <summary>
		/// Saves a record to the Articles table.
		/// </summary>
		void Update(ArticlesInfo articlesInfo);

		/// <summary>
		/// Delete a record from the Articles table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Deletes all records from the Articles table by foreign key value.
		/// </summary>
		void DeleteAllByCategoryID(int categoryID);

		/// <summary>
		/// Selects a single record from the Articles table.
		/// </summary>
		ArticlesInfo Select(int iD);

		/// <summary>
		/// Selects all records from the Articles table.
		/// </summary>
		CHRTList<ArticlesInfo> SelectAll();

		/// <summary>
		/// Selects all records from the Articles table by foreign key value.
		/// </summary>
		CHRTList<ArticlesInfo> SelectAllByCategoryID(int categoryID);

	}
}
