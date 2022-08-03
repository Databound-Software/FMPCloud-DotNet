using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class TradingHoursDetail
    {
        public string StockExchangeName { get; set; }
        public MarketHours StockMarketHours { get; set; }
        public List<MarketHolidays> StockMarketHolidays { get; set; }

        public TradingHoursDetail()
        {
            StockMarketHours = new MarketHours();
            StockMarketHolidays = new List<MarketHolidays>();
        }
    }

    public class MarketHours
    {
        public string OpeningHour { get; set; }
        public string ClosingHour { get; set; }
    }

    public class MarketHolidays
    {
        public int Year { get; set; }
        [JsonProperty("New Years Day")]
        public DateTime? NewYearsDay { get; set; }
        [JsonProperty("Martin Luther King, Jr. Day")]
        public DateTime? MartinLutherKingDay { get; set; }
        [JsonProperty("Washington's Birthday")]
        public DateTime? WashingtonsBirthday { get; set; }
        [JsonProperty("Good Friday")]
        public DateTime? GoodFriday { get; set; }
        [JsonProperty("Memorial Day")]
        public DateTime? MemorialDay { get; set; }
        [JsonProperty("Juneteenth National Independence Day")]
        public DateTime? Juneteenth { get; set; }
        [JsonProperty("Independence Day")]
        public DateTime? IndependenceDay { get; set; }
        [JsonProperty("Labor Day")]
        public DateTime? LaborDay { get; set; }
        [JsonProperty("Thanksgiving Day")]
        public DateTime? ThanksgivingDay { get; set; }
        [JsonProperty("Christmas Day")]
        public DateTime? ChristmasDay { get; set; }
    }
}
