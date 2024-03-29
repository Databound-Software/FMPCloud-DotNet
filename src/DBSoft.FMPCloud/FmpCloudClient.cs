﻿using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using DBSoft.FMPCloud.StockTimeSeries;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud
{
    public class FmpCloudClient : FmpBase, IFmpCloudClient
    {
        public IStockTimeSeries StockTimeSeries { get; set; }


        public FmpCloudClient(FmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            StockTimeSeries = new StockTimeSeriesFacade(configuration, submitter, logger);
        }
    }
}
