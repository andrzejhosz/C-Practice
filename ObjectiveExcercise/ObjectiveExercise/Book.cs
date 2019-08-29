namespace ObjectiveExercise
{
    namespace BookShop
    {
        public class Book
        {
            public string Author { get; }
            public string Title { get; }
            public decimal Price { get; }
            
            public Book(string author, string title, decimal price)
            {
                Author = author;
                Title = title;
                Price = price;
            }

            public virtual string GetCatalogDescription()
            {
                return $"Book {Author}: {Title}, available for {Price}";
            }
        }
        
        public class RareBook
        {
            public string Author { get; }
            public string Title { get; }
            public decimal Price { get; }
            public int NumberOfCopies { get; }
            
            public RareBook(string author, string title, decimal price, int numberOfCopies)
            {
                Author = author;
                Title = title;
                Price = price;
                NumberOfCopies = numberOfCopies;
            }

            public virtual string GetCatalogDescription()
            {
                return $"Rare book, you lucky bastard! Only {NumberOfCopies} was printed!\n " +
                       $"{Author}: {Title}, available for {Price}";
            }
        }
    }
}