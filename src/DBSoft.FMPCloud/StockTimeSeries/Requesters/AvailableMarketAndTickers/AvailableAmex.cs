﻿using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class AvailableAmex : AvailableSecuritiesBase, IAvailableSecurities
    {
        public AvailableAmex(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }

        public override Task<AvailableSecuritiesResponse> GetAsync(StandardRequestBase request = default)
        {
            return base.GetAsync(new StandardRequestBase { Symbol = "available-amex" });
        }
    }
}
