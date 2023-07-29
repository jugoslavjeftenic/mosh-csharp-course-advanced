namespace t02_01_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var number = new Nullable<int>();
            Console.WriteLine($"Has value? {number.HasValue}");
            Console.WriteLine($"Value: {number.GetValueOrDefault()}");
        }
    }
}