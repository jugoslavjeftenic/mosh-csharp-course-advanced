namespace t02_09_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var calculator = new Calculator();
                //var result = calculator.Divide(5, 0);

                //using var streamReader = new StreamReader(@"c:\file.zip");
                //var content = streamReader.ReadToEnd();

                var api = new YouTubeApi();
                var videos = api.GetVideos("Jugoslav");
            }
            //catch (DivideByZeroException e)
            //{
            //Console.WriteLine("You cannot divide by zero.");
            //}
            catch (Exception e)
            {
                //Console.WriteLine("Sorry, an unexpected error occured.");
                Console.WriteLine(e.Message);
            }
            //finally
            //{
            //    streamReader?.Dispose();
            //}
        }
    }
}