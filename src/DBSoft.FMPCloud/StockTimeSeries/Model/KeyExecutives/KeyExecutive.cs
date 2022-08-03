using System;


namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class KeyExecutive
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public long? Pay { get; set; }
        public string CurrencyPay { get; set; }
        public string Gender { get; set; }
        public int? YearBorn { get; set; }
        public DateTime? TitleSince { get; set; }
    }
}
