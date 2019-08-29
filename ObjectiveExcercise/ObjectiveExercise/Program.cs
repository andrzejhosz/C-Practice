using System;
using ObjectiveExercise.BookShop;

namespace ObjectiveExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("======= New book info:");

                Console.WriteLine("= Author:");
                var author = Console.ReadLine();
                
                Console.WriteLine("= Title:");
                var title = Console.ReadLine();
                
                Console.WriteLine("= Price:");
                var price = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine("= Number of copies:");
                var numberOfCopies = int.Parse(Console.ReadLine());
                
                var catalogDescription = string.Empty;
                if (numberOfCopies > 200)
                {
                    var book = new Book(author, title, price);
                    catalogDescription = book.GetCatalogDescription();
                }
                else
                {
                    var rareBook = new RareBook(author, title, price, numberOfCopies);
                    catalogDescription = rareBook.GetCatalogDescription();
                }

                Console.WriteLine("============ ADDED: ===============");
                Console.WriteLine(catalogDescription);
                
                
                
                
                
                
                
                
                
                
                
                // =================== ponizej: wyjście z programu, nie zmieniaj tego kodu ===================
                
                Console.WriteLine("=== Press Q to quit, or ano other key to continue ===");
                if (ShouldExit(Console.ReadKey().Key))
                {
                    break;
                }
            }
        }

        private static bool ShouldExit(ConsoleKey key) => key == ConsoleKey.Q;
    }
}