using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace CoderGirl_SalesList
{
    public class Program
    {
        private string filePath = @"Data/1000 Sales Records.csv";

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            Console.ReadLine();
        }

        private void Run()
        {
            Factory factory = new Factory();
            ISalesRecordAdapter salesRecordAdapter = factory.SalesRecordAdapter;
            List<SalesRecord> salesRecords = salesRecordAdapter.GetSalesRecordsFromCsvFile(filePath);

            ISalesRecordAnalyzer salesRecordAnalyzer = factory.SalesRecordAnalyzer;
            List<string> countries = salesRecordAnalyzer.GetCountries(salesRecords);

            //Testing for Country List
            countries.Sort();
            countries.ForEach(country => Console.WriteLine(country));
            Console.ReadLine();

            //Testing for Country Count
            int countryCount = salesRecordAnalyzer.GetCountryCount(salesRecords);
            Console.WriteLine(countryCount);
            Console.ReadLine();

            //Testing for MaxProfit
            decimal maxProfit = salesRecordAnalyzer.GetMaxProfit(salesRecords);
            Console.WriteLine($"Maximum Profit is: {maxProfit}");
            Console.ReadLine();

            //Testing for TotalRevenue
            decimal totalRevenue = salesRecordAnalyzer.GetTotalRevenue(salesRecords);
            Console.WriteLine($"Total Revenue is: {totalRevenue}");
            Console.ReadLine();

            //Testing for OrderByShipDate
            List<SalesRecord> ascendingOrderOfShipDates = salesRecordAnalyzer.OrderByShipDate(salesRecords);
            ascendingOrderOfShipDates.ForEach(record => Console.WriteLine(record.OrderDate.ToString("M/d/yyyy")));
            Console.ReadLine();

            //Testing for OrderByUnitsSoldDescending
            List<SalesRecord> orderByUnitsSoldDescending =  salesRecordAnalyzer.OrderByUnitsSoldDescending(salesRecords);
            orderByUnitsSoldDescending.ForEach(record => Console.WriteLine(record.UnitsSold));
            Console.ReadLine();

            //Testing for AreOrderDatesBefore

            DateTime cutoffDate = DateTime.Parse("7/26/2017");
            Console.WriteLine(salesRecordAnalyzer.AreOrderDatesBefore(cutoffDate , salesRecords));
            Console.ReadLine();

            //List<SalesRecord> salesRecords = GetSalesRecordsFromFileData();
            //int countNorthAmerica = GetCountForNorthAmerica(salesRecords);
            //Console.WriteLine(countNorthAmerica);
        }

        //private int GetCountForNorthAmerica(List<SalesRecord> salesRecords)
        //{
        //    int count = 0;
        //    foreach(SalesRecord record in salesRecords)
        //    {
        //        if(record.Region == "North America")
        //        {
        //            count++;
        //        }
        //    }
        //    int[] something = new int[5];

        //    something.TakeLast(4);

        //    List<string> stringList = new List<string>();
        //    stringList.Select(item => int.Parse(item)).ToList();
        //    return count;
        //}
    }
}