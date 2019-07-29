using System;

namespace YearsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any year:");

            var useryear = int.Parse(Console.ReadLine());
            Console.WriteLine();
            var today = DateTime.Now.Year;

            if (useryear <= 0)
            {
                Console.WriteLine("Entered year must be higher then 0 ");
            }
            else
            {
                if ( useryear - (useryear/100*100) == 0)
                {
                    var century = (useryear / 100);
                    Console.WriteLine($"Your year is {century} century");
                }
                else
                {
                    var century = (useryear / 100) + 1;
                    Console.WriteLine($"Your year is {century} century");
                }                
            }
            Console.WriteLine();

            if (today - useryear >= 0)
            {
                Console.WriteLine($"Your year was {today - useryear} years ago.");
            }           
            else
            {
                Console.WriteLine($"Your year will be in {useryear - today} years.");
            }
            Console.ReadKey();
        }
    }
}
