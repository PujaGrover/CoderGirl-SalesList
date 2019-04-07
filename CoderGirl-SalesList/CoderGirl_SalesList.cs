using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoderGirl_SalesList
{
    //public class WhateverUneed : ISalesRecordAdapter
    //{
    //    public List<SalesRecord> GetSalesRecordsFromCsvFile(string filePath, bool header = false)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    public class WhateverUwant : ISalesRecordAnalyzer
    {
        public bool AreOrderDatesBefore(DateTime cutoffDate, List<SalesRecord> salesRecords)
        {
            decimal[] profits = { 1.3, 3.44, 4.9 };

            bool result = salesRecords.Any(record => profits.Contains(record.TotalProfit));

        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            List<string> results = salesRecords.Select(record => record.Country).Distinct().ToList();
            //results = results.Distinct().ToList();
            return results;
        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetMaxProfit(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public decimal GetTotalRevenue(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByShipDate(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }

        public List<SalesRecord> OrderByUnitsSoldDescending(List<SalesRecord> salesRecords)
        {
            throw new NotImplementedException();
        }
    }
}
