namespace t02_05_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }
}