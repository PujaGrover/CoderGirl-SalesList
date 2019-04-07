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
            throw new NotImplementedException();
        }

        public List<string> GetCountries(List<SalesRecord> salesRecords)
        {
            /// <summary>
            /// Returns number of unique countries for which there are a Sales Record 
            /// </summary>
            /// <param name="salesRecords"></param>
            /// <returns></returns>
            //int GetCountryCount(List<SalesRecord> salesRecords);
            List<string> results = salesRecords.Select(record => record.Country).Distinct().ToList();
            //        //results = results.Distinct().ToList();
            Console.WriteLine(results);
            Console.ReadLine();
                return results;

        }

        public int GetCountryCount(List<SalesRecord> salesRecords)
        {

            throw new NotImplementedException();

            //return count;

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
