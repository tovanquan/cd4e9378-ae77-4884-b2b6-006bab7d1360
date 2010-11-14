using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class HostingsDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public HostingsDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Hostings table.
		/// </summary>
		public virtual void Insert(HostingsInfo hostingsInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", hostingsInfo.CustomerID),
				new SqlParameter("@Package", hostingsInfo.Package),
				new SqlParameter("@StartDate", hostingsInfo.StartDate),
				new SqlParameter("@ExpireDate", hostingsInfo.ExpireDate)
			};

			hostingsInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Hostings_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Hostings table.
		/// </summary>
		public virtual void Update(HostingsInfo hostingsInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", hostingsInfo.ID),
				new SqlParameter("@CustomerID", hostingsInfo.CustomerID),
				new SqlParameter("@Package", hostingsInfo.Package),
				new SqlParameter("@StartDate", hostingsInfo.StartDate),
				new SqlParameter("@ExpireDate", hostingsInfo.ExpireDate)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Hostings_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Hostings table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Hostings_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the Hostings table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCustomerID(int customerID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", customerID)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Hostings_DeleteAllByCustomerID", parameters);
		}

		/// <summary>
		/// Selects a single record from the Hostings table.
		/// </summary>
		public virtual HostingsInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Hostings_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeHostingsInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Hostings table.
		/// </summary>
		public CHRTList<HostingsInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Hostings_SelectAll"))
			{
				CHRTList<HostingsInfo> hostingsInfoList = new CHRTList<HostingsInfo>();
				while (dataReader.Read())
				{
					HostingsInfo hostingsInfo = MakeHostingsInfo(dataReader);
					hostingsInfoList.Add(hostingsInfo);
				}

				return hostingsInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the Hostings table by a foreign key.
		/// </summary>
		public virtual CHRTList<HostingsInfo> SelectAllByCustomerID(int customerID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", customerID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Hostings_SelectAllByCustomerID", parameters))
			{
				CHRTList<HostingsInfo> hostingsInfoList = new CHRTList<HostingsInfo>();
				while (dataReader.Read())
				{
					HostingsInfo hostingsInfo = MakeHostingsInfo(dataReader);
					hostingsInfoList.Add(hostingsInfo);
				}

				return hostingsInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Hostings class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual HostingsInfo MakeHostingsInfo(SqlDataReader dataReader)
		{
			HostingsInfo hostingsInfo = new HostingsInfo();
			hostingsInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.HOSTINGS.ID, 0);
			hostingsInfo.CustomerID = SqlClientUtility.GetInt32(dataReader,DbConstants.HOSTINGS.CUSTOMERID, 0);
			hostingsInfo.Package = SqlClientUtility.GetString(dataReader,DbConstants.HOSTINGS.PACKAGE, String.Empty);
			hostingsInfo.StartDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.HOSTINGS.STARTDATE, DateTime.Now);
			hostingsInfo.ExpireDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.HOSTINGS.EXPIREDATE, DateTime.Now);

			return hostingsInfo;
		}

		#endregion
	}
}
