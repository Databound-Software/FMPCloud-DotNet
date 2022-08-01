﻿
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class CompanyProfile : BatchRequesterWithRequestBase<CompanyProfileRequest, CompanyProfileResponse, List<Model.CompanyProfile>>, ICompanyProfile
    {

        public CompanyProfile(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger) : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.CompanyProfilePath;
        }
    }
}
