namespace t02_06_Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "ADO.Net Step by Step", Price = 3 },
                new Book() { Title = "ADO.NET MVC", Price = 9.99f },
                new Book() { Title = "ADO.NET Web API", Price = 12 },
                new Book() { Title = "C# Advanced Topics", Price = 4 },
                new Book() { Title = "C# Advanced Topics", Price = 9 }
            };
        }
    }
}