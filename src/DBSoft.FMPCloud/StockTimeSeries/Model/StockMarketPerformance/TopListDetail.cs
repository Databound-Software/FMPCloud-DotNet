namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class TopListDetail
    {
        public string Ticket { get; set; }
        public decimal Changes { get; set; }
        public decimal Price { get; set; }
        public decimal ChangesPercentage { get; set; }
        public string CompanyName { get; set; }
    }
}
