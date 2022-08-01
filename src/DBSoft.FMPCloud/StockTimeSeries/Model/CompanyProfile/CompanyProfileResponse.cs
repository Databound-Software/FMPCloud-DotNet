using System;
using System.Collections.Generic;
using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class CompanyProfileResponse : ResponseBase<List<CompanyProfile>>
    {
        
    }

    public class CompanyProfile
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public decimal Beta { get; set; }
        public long VolAvg { get; set; }
        public long MktCap { get; set; }
        public decimal LastDiv { get; set; }
        public string Range { get; set; }
        public decimal Changes { get; set; }
        public string CompanyName { get; set; }
        public string Currency { get; set; }
        public string Cik { get; set; }
        public string Isin { get; set; }
        public string Cuisp { get; set; }
        public string Exchange { get; set; }
        public Exchange ExchangeShortName { get; set; }
        public string Industry { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public string Ceo { get; set; }
        public string Sector { get; set; }
        public string Country { get; set; }
        public long FullTimeEmployees { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public decimal DcfDiff { get; set; }
        public decimal Dcf { get; set; }
        public string Image { get; set; }
        public DateTime IpoDate { get; set; }
        public bool DefaultImage { get; set; }
        public bool IsEtf { get; set; }
        public bool IsActivelyTrading { get; set; }
    }
}
