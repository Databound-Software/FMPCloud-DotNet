using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class CompanyProfile : BatchRequesterWithRequestBase<CompanyProfileRequest, List<Model.CompanyProfile>>, ICompanyProfile
    {

        public CompanyProfile(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger) : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.CompanyProfilePath;
        }
    }
}
