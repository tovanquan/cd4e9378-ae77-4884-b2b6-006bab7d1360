using System;
using System.Collections.Generic;

using thietkeso.DAL;
using thietkeso.Common.Models;
using thietkeso.Biz.Services;

namespace thietkeso.Biz.Implements
{
	public class VisitService: IVisitService
	{
		/// <summary>
		/// Selects all records from the Visit table.
		/// </summary>
		
        public CHRTList<VisitInfo> SelectAll()
		{
			try
			{
				return new VisitDAO().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "thietkeso.Biz.Implements.Visit - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
