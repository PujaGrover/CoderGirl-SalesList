using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{
    class SalesRecordAnalyzer : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            bool result = salesRecords.Any(record => record.OrderDate <= cutoffDate);
            return result;
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> results = salesRecords.Select(record => record.Country).Distinct().ToList();
            //results = results.Distinct().ToList();  ANOTHER WAY OF Doing the same task as above         
                return results;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            int count = salesRecords.Select(record => record.Country).Distinct(StringComparer.OrdinalIgnoreCase).Count();
            return count;
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            decimal count = salesRecords.Select(record => record.TotalProfit).Max();
            return count;
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            decimal totalRevenue = salesRecords.Sum(record => record.TotalRevenue);
            return totalRevenue;
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            List<SalesRecord> asendingOrderOfShipDate =  salesRecords.OrderBy(record => record.ShipDate).ToList();
            return asendingOrderOfShipDate;
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            List<SalesRecord> orderByUnitsSoldDescending =  salesRecords.OrderByDescending(record => record.UnitsSold).ToList();
            return orderByUnitsSoldDescending;
        }
    }
}
