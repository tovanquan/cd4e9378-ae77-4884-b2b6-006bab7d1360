using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class WebsitesDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public WebsitesDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Websites table.
		/// </summary>
		public virtual void Insert(WebsitesInfo websitesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", websitesInfo.CustomerID),
				new SqlParameter("@Link", websitesInfo.Link),
				new SqlParameter("@Image", websitesInfo.Image),
				new SqlParameter("@Description", websitesInfo.Description),
				new SqlParameter("@Cost", websitesInfo.Cost),
				new SqlParameter("@StartDate", websitesInfo.StartDate),
				new SqlParameter("@FinishDate", websitesInfo.FinishDate)
			};

			websitesInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Websites_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Websites table.
		/// </summary>
		public virtual void Update(WebsitesInfo websitesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", websitesInfo.ID),
				new SqlParameter("@CustomerID", websitesInfo.CustomerID),
				new SqlParameter("@Link", websitesInfo.Link),
				new SqlParameter("@Image", websitesInfo.Image),
				new SqlParameter("@Description", websitesInfo.Description),
				new SqlParameter("@Cost", websitesInfo.Cost),
				new SqlParameter("@StartDate", websitesInfo.StartDate),
				new SqlParameter("@FinishDate", websitesInfo.FinishDate)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Websites_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Websites table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Websites_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the Websites table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCustomerID(int customerID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", customerID)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Websites_DeleteAllByCustomerID", parameters);
		}

		/// <summary>
		/// Selects a single record from the Websites table.
		/// </summary>
		public virtual WebsitesInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Websites_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeWebsitesInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Websites table.
		/// </summary>
		public CHRTList<WebsitesInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Websites_SelectAll"))
			{
				CHRTList<WebsitesInfo> websitesInfoList = new CHRTList<WebsitesInfo>();
				while (dataReader.Read())
				{
					WebsitesInfo websitesInfo = MakeWebsitesInfo(dataReader);
					websitesInfoList.Add(websitesInfo);
				}

				return websitesInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the Websites table by a foreign key.
		/// </summary>
		public virtual CHRTList<WebsitesInfo> SelectAllByCustomerID(int customerID)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@CustomerID", customerID)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Websites_SelectAllByCustomerID", parameters))
			{
				CHRTList<WebsitesInfo> websitesInfoList = new CHRTList<WebsitesInfo>();
				while (dataReader.Read())
				{
					WebsitesInfo websitesInfo = MakeWebsitesInfo(dataReader);
					websitesInfoList.Add(websitesInfo);
				}

				return websitesInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Websites class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual WebsitesInfo MakeWebsitesInfo(SqlDataReader dataReader)
		{
			WebsitesInfo websitesInfo = new WebsitesInfo();
			websitesInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.WEBSITES.ID, 0);
			websitesInfo.CustomerID = SqlClientUtility.GetInt32(dataReader,DbConstants.WEBSITES.CUSTOMERID, 0);
			websitesInfo.Link = SqlClientUtility.GetString(dataReader,DbConstants.WEBSITES.LINK, String.Empty);
			websitesInfo.Image = SqlClientUtility.GetString(dataReader,DbConstants.WEBSITES.IMAGE, String.Empty);
			websitesInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.WEBSITES.DESCRIPTION, String.Empty);
			websitesInfo.Cost = SqlClientUtility.GetDecimal(dataReader,DbConstants.WEBSITES.COST, Decimal.Zero);
			websitesInfo.StartDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.WEBSITES.STARTDATE, DateTime.Now);
			websitesInfo.FinishDate = SqlClientUtility.GetDateTime(dataReader,DbConstants.WEBSITES.FINISHDATE, DateTime.Now);

			return websitesInfo;
		}

		#endregion
	}
}
