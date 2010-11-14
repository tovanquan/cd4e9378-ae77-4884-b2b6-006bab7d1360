using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IUsersService
	{
		/// <summary>
		/// Saves a record to the Users table.
		/// </summary>
		void Insert(UsersInfo usersInfo);

		/// <summary>
		/// Saves a record to the Users table.
		/// </summary>
		void Update(UsersInfo usersInfo);

		/// <summary>
		/// Delete a record from the Users table.
		/// </summary>
		void Delete(int iD);

		/// <summary>
		/// Selects a single record from the Users table.
		/// </summary>
		UsersInfo Select(int iD);

        /// <summary>
        /// Selects a signle record from the Users table , by UserName
        /// </summary>
        /// <param name="userName">user name</param>
        /// <returns></returns>
        UsersInfo SelectByUserName(string userName);

		/// <summary>
		/// Selects all records from the Users table.
		/// </summary>
		CHRTList<UsersInfo> SelectAll();

	}
}
