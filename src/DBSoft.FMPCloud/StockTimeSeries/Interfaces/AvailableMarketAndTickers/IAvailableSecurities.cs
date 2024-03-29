﻿using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IAvailableSecurities : IRequester<StandardRequestBase, List<AvailableSecurity>>
    {
    }
}
