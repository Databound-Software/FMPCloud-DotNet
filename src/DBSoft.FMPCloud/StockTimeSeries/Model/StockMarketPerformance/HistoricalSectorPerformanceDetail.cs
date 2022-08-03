using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class HistoricalSectorPerformanceDetail
    {
        public DateTime Date { get; set; }

        public decimal UtilitiesChangesPercentage { get; set; }
        public decimal BasicMaterialsChangesPercentage { get; set; }
        public decimal CommunicationServicesChangesPercentage { get; set; }
        public decimal ConglomeratesChangesPercentage { get; set; }
        public decimal ConsumerCyclicalChangesPercentage { get; set; }
        public decimal ConsumerDefensiveChangesPercentage { get; set; }
        public decimal EnergyChangesPercentage { get; set; }
        public decimal FinancialChangesPercentage { get; set; }
        public decimal FinancialServicesChangesPercentages { get; set; }
        public decimal HealthcareChangesPercentage { get; set; }
        public decimal IndustrialsChangesPercentage { get; set; }
        public decimal RealEstateChangesPercentage { get; set; }
        public decimal ServicesChagesPercentage { get; set; }
        public decimal TechnologyChangesPercentage { get; set; }
    }
}
