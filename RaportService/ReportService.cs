using System;
using System.Collections.Generic;
using System.IO;
using ReportService.Models;

namespace ReportService
{
    public class ReportService
    {
        public string CreateProductsReport(
            DateTime saleDateEnd,
            List<Tuple<Product, int>> productsWithSalesCount)
        {
            var filePath = "Reports" + Guid.NewGuid() + ".txt";

            var writeStream = new StreamWriter(File.Create(filePath));

            writeStream.WriteLine($"Sales raport start : {saleDateEnd.Date.AddDays(-7).ToShortDateString()}" + $"\nSales raport end : {saleDateEnd.ToShortDateString()}\n");

            foreach (var tuple in productsWithSalesCount)
            {
                writeStream.WriteLine($"Product : {tuple.Item1.Name}\nPrice : {tuple.Item1.Price}" + $"\nSold :{tuple.Item2}\n ");
            }
            writeStream.Close();
            return filePath;
        }
    }
}
