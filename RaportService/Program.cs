using System;
using System.Collections.Generic;
using System.IO;
using ReportService.Models;

namespace ReportService
{
	class Program
	{
		static void Main(string[] args)
		{
			var sellDateEnd = DateTime.Now;
			var productsSalesData = new List<Tuple<Product, int>>
			{
				Tuple.Create(new Product("Browar", 5), 100),
				Tuple.Create(new Product("Whisky", 100), 10),
				Tuple.Create(new Product("Rum", 30), 7),
				Tuple.Create(new Product("Wódka", 23), 203),
				Tuple.Create(new Product("Brandy", 43), 16),
				Tuple.Create(new Product("Piwo bezalkoholowe", 2), 0)
			};

            var reportService = new ReportService();

			var reportFilepath = reportService.CreateProductsReport(sellDateEnd, productsSalesData);

			var fileInfo = new FileInfo(reportFilepath);

			Console.WriteLine($"File created ? - {fileInfo.Exists}");

			if (fileInfo.Exists)
			{
				Console.WriteLine($"Length of file in bites : - {fileInfo.Length}");

				if (fileInfo.Length == 0)
				{
					Console.WriteLine("Plik pusty - coś nie tak ;)");
				}

				using (var streamReader = fileInfo.OpenText())
				{
					var reportData = streamReader.ReadToEnd();

					Console.Write(reportData);
				}
			}
			else
			{
				Console.WriteLine("Coś poszło nie tak");
			}

			Console.ReadKey();
		}
	}
}
