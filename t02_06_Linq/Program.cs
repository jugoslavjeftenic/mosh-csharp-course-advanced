namespace t02_06_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // classic
            var expensiveBooks = new List<Book>();
            foreach (var b in books)
            {
                if (b.Price > 10)
                {
                    expensiveBooks.Add(b);
                }
            }

            foreach (var b in expensiveBooks)
            {
                Console.WriteLine($"{b.Title} {b.Price}");
            }
            Console.WriteLine();

            // Linq
            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 5
                orderby b.Title descending
                select b.Title;

            foreach (var b in cheaperBooks)
            {
                Console.WriteLine(b);
                //Console.WriteLine($"{cb.Title} {cb.Price}");
            }
            Console.WriteLine();

            // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderByDescending(b => b.Title)
                .Select(b => b.Title);

            foreach (var b in cheapBooks)
            {
                Console.WriteLine(b);
                //Console.WriteLine($"{cb.Title} {cb.Price}");
            }
            Console.WriteLine();

            Console.WriteLine(books.Single(b => b.Title == "ADO.NET MVC").Title);
            Console.WriteLine(books.First(b => b.Title == "C# Advanced Topics").Price);
            Console.WriteLine(books.Last(b => b.Title == "C# Advanced Topics").Price);
            Console.WriteLine(books.Count());
            Console.WriteLine(books.Max(b => b.Price));
            Console.WriteLine(books.Min(b => b.Price));
            Console.WriteLine(books.Sum(b => b.Price));
            Console.WriteLine(books.Average(b => b.Price));
            Console.WriteLine();

            var pagedBooks = books.Skip(2).Take(3);
            foreach (var b in pagedBooks)
            {
                Console.WriteLine($"{b.Title} {b.Price}");
            }
            Console.WriteLine();
        }
    }
}