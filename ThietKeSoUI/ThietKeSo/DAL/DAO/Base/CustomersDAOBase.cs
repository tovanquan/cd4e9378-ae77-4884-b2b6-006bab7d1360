using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL.Base
{
	public class CustomersDAOBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public CustomersDAOBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Customers table.
		/// </summary>
		public virtual void Insert(CustomersInfo customersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@Name", customersInfo.Name),
				new SqlParameter("@Address", customersInfo.Address),
				new SqlParameter("@Mobile", customersInfo.Mobile),
				new SqlParameter("@Email", customersInfo.Email),
				new SqlParameter("@Note", customersInfo.Note)
			};

			customersInfo.ID = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "Customers_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the Customers table.
		/// </summary>
		public virtual void Update(CustomersInfo customersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", customersInfo.ID),
				new SqlParameter("@Name", customersInfo.Name),
				new SqlParameter("@Address", customersInfo.Address),
				new SqlParameter("@Mobile", customersInfo.Mobile),
				new SqlParameter("@Email", customersInfo.Email),
				new SqlParameter("@Note", customersInfo.Note)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Customers_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the Customers table by its primary key.
		/// </summary>
		public virtual void Delete(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "Customers_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the Customers table.
		/// </summary>
		public virtual CustomersInfo Select(int iD)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ID", iD)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Customers_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCustomersInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the Customers table.
		/// </summary>
		public CHRTList<CustomersInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Customers_SelectAll"))
			{
				CHRTList<CustomersInfo> customersInfoList = new CHRTList<CustomersInfo>();
				while (dataReader.Read())
				{
					CustomersInfo customersInfo = MakeCustomersInfo(dataReader);
					customersInfoList.Add(customersInfo);
				}

				return customersInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the Customers class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual CustomersInfo MakeCustomersInfo(SqlDataReader dataReader)
		{
			CustomersInfo customersInfo = new CustomersInfo();
			customersInfo.ID = SqlClientUtility.GetInt32(dataReader,DbConstants.CUSTOMERS.ID, 0);
			customersInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.CUSTOMERS.NAME, String.Empty);
			customersInfo.Address = SqlClientUtility.GetString(dataReader,DbConstants.CUSTOMERS.ADDRESS, String.Empty);
			customersInfo.Mobile = SqlClientUtility.GetString(dataReader,DbConstants.CUSTOMERS.MOBILE, String.Empty);
			customersInfo.Email = SqlClientUtility.GetString(dataReader,DbConstants.CUSTOMERS.EMAIL, String.Empty);
			customersInfo.Note = SqlClientUtility.GetString(dataReader,DbConstants.CUSTOMERS.NOTE, String.Empty);

			return customersInfo;
		}

		#endregion
	}
}
