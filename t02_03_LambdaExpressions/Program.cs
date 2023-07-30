namespace t02_03_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(5));

            // args => expression
            // number => number * number
            // () => ...
            // x => ...
            // (x, y, z) => ...

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;
            Func<int, int> multipler = n => n * factor;
            Console.WriteLine(multipler(10));

            // -------------------------------------
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var b in cheapBooks)
            {
                Console.WriteLine(b.Title);
            }
            Console.WriteLine();

            var expensiveBooks = books.FindAll(b => b.Price >= 10);

            foreach (var b in expensiveBooks)
            {
                Console.WriteLine(b.Title);
            }
        }

        static int Square(int number)
        {
            return number * number;
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}