using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class DomainsDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public DomainsDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Domains table.
		/// </summary>
		public virtual void Insert(DomainsInfo domainsInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Name", domainsInfo.Name),
				new SqlParameter("@CustomerID", domainsInfo.CustomerID),
				new SqlParameter("@Domain", domainsInfo.Domain),
				new SqlParameter("@StartDate", domainsInfo.StartDate),
				new SqlParameter("@ExpireDate", domainsInfo.ExpireDate)
			};

			domainsInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Domains_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Domains table.
		/// </summary>
		public virtual void Update(DomainsInfo domainsInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", domainsInfo.ID),
				new SqlParameter("@Name", domainsInfo.Name),
				new SqlParameter("@CustomerID", domainsInfo.CustomerID),
				new SqlParameter("@Domain", domainsInfo.Domain),
				new SqlParameter("@StartDate", domainsInfo.StartDate),
				new SqlParameter("@ExpireDate", domainsInfo.ExpireDate)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Domains_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Domains table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Domains_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the Domains table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCustomerID(int customerID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", customerID)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Domains_DeleteAllByCustomerID", parameters);
		}

		/// <summary>
		/// Selects a single record from the Domains table.
		/// </summary>
		public virtual DomainsInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Domains_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeDomainsInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Domains table.
		/// </summary>
		public CHRTList<DomainsInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Domains_SelectAll"))
			{
				CHRTList<DomainsInfo> domainsInfoList = new CHRTList<DomainsInfo>();
				while (dataReader.Read())
				{
					DomainsInfo domainsInfo = MakeDomainsInfo(dataReader);
					domainsInfoList.Add(domainsInfo);
				}

				return domainsInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the Domains table by a foreign key.
		/// </summary>
		public virtual CHRTList<DomainsInfo> SelectAllByCustomerID(int customerID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", customerID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Domains_SelectAllByCustomerID", parameters))
			{
				CHRTList<DomainsInfo> domainsInfoList = new CHRTList<DomainsInfo>();
				while (dataReader.Read())
				{
					DomainsInfo domainsInfo = MakeDomainsInfo(dataReader);
					domainsInfoList.Add(domainsInfo);
				}

				return domainsInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Domains class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual DomainsInfo MakeDomainsInfo(SqlDataReader dataReader)
		{
			DomainsInfo domainsInfo = new DomainsInfo();
			domainsInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.DOMAINS.ID, 0);
			domainsInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.DOMAINS.NAME, String.Empty);
			domainsInfo.CustomerID = SqlClientUtility.GetInt32(dataReader,DbConstants.DOMAINS.CUSTOMERID, 0);
			domainsInfo.Domain = SqlClientUtility.GetString(dataReader,DbConstants.DOMAINS.DOMAIN, String.Empty);
			domainsInfo.StartDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.DOMAINS.STARTDATE, DateTime.Now);
			domainsInfo.ExpireDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.DOMAINS.EXPIREDATE, DateTime.Now);

			return domainsInfo;
		}

		#endregion
	}
}
