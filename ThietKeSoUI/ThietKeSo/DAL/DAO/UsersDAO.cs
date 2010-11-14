using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Base;
using thietkeso.DAL.Utils;
using thietkeso.Common.Models;

namespace thietkeso.DAL
{
	public class UsersDAO : UsersDAOBase
	{
		#region Constructors

		public UsersDAO()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods
        /// <summary>
        /// Select User By UserName
        /// </summary>
        /// <param name="userName">UserName</param>
        /// <returns>UserInfo</returns>
        public UsersInfo SelectByUserName(string userName)
        {
            SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@UserName", userName)
			};

            using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "Users_SelectByUserName", parameters))
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
		#endregion
	}
}
