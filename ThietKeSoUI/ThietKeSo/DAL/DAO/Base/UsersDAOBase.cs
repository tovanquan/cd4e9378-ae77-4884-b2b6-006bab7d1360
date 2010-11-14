using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class UsersDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public UsersDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Users table.
		/// </summary>
		public virtual void Insert(UsersInfo usersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Username", usersInfo.Username),
				new SqlParameter("@Password", usersInfo.Password),
				new SqlParameter("@Name", usersInfo.Name),
				new SqlParameter("@Mobile", usersInfo.Mobile),
				new SqlParameter("@Email", usersInfo.Email),
				new SqlParameter("@Posision", usersInfo.Posision),
				new SqlParameter("@Note", usersInfo.Note)
			};

			usersInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Users_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Users table.
		/// </summary>
		public virtual void Update(UsersInfo usersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", usersInfo.ID),
				new SqlParameter("@Username", usersInfo.Username),
				new SqlParameter("@Password", usersInfo.Password),
				new SqlParameter("@Name", usersInfo.Name),
				new SqlParameter("@Mobile", usersInfo.Mobile),
				new SqlParameter("@Email", usersInfo.Email),
				new SqlParameter("@Posision", usersInfo.Posision),
				new SqlParameter("@Note", usersInfo.Note)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Users_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Users table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Users_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the Users table.
		/// </summary>
		public virtual UsersInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Users_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeUsersInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Users table.
		/// </summary>
		public CHRTList<UsersInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Users_SelectAll"))
			{
				CHRTList<UsersInfo> usersInfoList = new CHRTList<UsersInfo>();
				while (dataReader.Read())
				{
					UsersInfo usersInfo = MakeUsersInfo(dataReader);
					usersInfoList.Add(usersInfo);
				}

				return usersInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Users class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual UsersInfo MakeUsersInfo(SqlDataReader dataReader)
		{
			UsersInfo usersInfo = new UsersInfo();
			usersInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.USERS.ID, 0);
			usersInfo.Username = SqlClientUtility.GetString(dataReader,DbConstants.USERS.USERNAME, String.Empty);
			usersInfo.Password = SqlClientUtility.GetString(dataReader,DbConstants.USERS.PASSWORD, String.Empty);
			usersInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.USERS.NAME, String.Empty);
			usersInfo.Mobile = SqlClientUtility.GetString(dataReader,DbConstants.USERS.MOBILE, String.Empty);
			usersInfo.Email = SqlClientUtility.GetString(dataReader,DbConstants.USERS.EMAIL, String.Empty);
			usersInfo.Posision = SqlClientUtility.GetString(dataReader,DbConstants.USERS.POSISION, String.Empty);
			usersInfo.Note = SqlClientUtility.GetString(dataReader,DbConstants.USERS.NOTE, String.Empty);

			return usersInfo;
		}

		#endregion
	}
}
