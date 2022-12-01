﻿using com.efrata.support.lib.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.efrata.support.lib.Interfaces
{
    public interface IFinishingOutOfGoodService
    {
        Tuple<List<FinishingOutOfGoodViewModel>, int> GetReport(DateTime? dateFrom, DateTime? dateTo, int page, int size, string Order);
        MemoryStream GenerateExcel(DateTime? dateFrom, DateTime? dateTo);
    }
}
