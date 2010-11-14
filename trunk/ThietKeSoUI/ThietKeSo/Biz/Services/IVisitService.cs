using System;
using System.Collections.Generic;

using thietkeso.Common.Models;

namespace thietkeso.Biz.Services
{
	public interface IVisitService
	{
		/// <summary>
		/// Selects all records from the Visit table.
		/// </summary>

        CHRTList<VisitInfo> SelectAll();

	}
}
