using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class StockDividendDetail
    {
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public decimal AdjDividend { get; set; }
        public decimal Dividend { get; set; }
        public DateTime RecordDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DeclarationDate { get; set; }
    }
}
