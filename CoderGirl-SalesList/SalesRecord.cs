using System;

namespace CoderGirl_SalesList
{
    public class SalesRecord
    {
        public string Region { get; set; }
        public string Country { get; set; }
        public string ItemType { get; set; }
        public string SalesChannel { get; set; }
        public string OrderPriority { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderId { get; set; }
        public DateTime ShipDate { get; set; }
        public int UnitsSold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalProfit { get; set; }
        //TODO: Add the other properties

        //Region,Country,Item Type, Sales Channel,Order Priority, Order Date,Order ID, Ship Date,Units Sold, Unit Price,Unit Cost, Total Revenue,Total Cost, Total Profit


    }
}