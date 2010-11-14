using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;
namespace thietkeso.Biz.Implements
{
	public class UsersService: IUsersService
	{
		/// <summary>
		/// Saves a record to the Users table.
		/// </summary>
		public virtual void Insert(UsersInfo usersInfo)
		{
			try
			{
				new UsersDAO().Insert(usersInfo);
			}
			catch (Exception ex)
			{
				////Provider.Log.Error(ex, "thietkeso.Biz.Implements.Users - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the Users table.
		/// </summary>
		public virtual void Update(UsersInfo usersInfo)
		{
			try
			{
				new UsersDAO().Update(usersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Users - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the Users table.
		/// </summary>
		public virtual void Delete(int iD)
		{
			try
			{
				new UsersDAO().Delete(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Users - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the Users table.
		/// </summary>
		public virtual UsersInfo Select(int iD)
		{
			try
			{
				return new UsersDAO().Select(iD);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Users - Select" + ex.Message);
				throw;
			}

		}

        public virtual UsersInfo SelectByUserName(string userName)
        {
            try
            {
                return new UsersDAO().SelectByUserName(userName);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

		/// <summary>
		/// Selects all records from the Users table.
		/// </summary>
		public CHRTList<UsersInfo> SelectAll()
		{
			try
			{
				return new UsersDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Users - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
