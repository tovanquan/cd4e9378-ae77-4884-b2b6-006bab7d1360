using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using thietkeso.DAL.Base;
using thietkeso.DAL.Utils;

namespace thietkeso.DAL
{
	public class CustomersDAO : CustomersDAOBase
	{
		#region Constructors

		public CustomersDAO()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods


		#endregion
	}
}
