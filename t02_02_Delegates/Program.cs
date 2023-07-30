namespace t02_02_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplayContrast;
            filterHandler += RemoveRedEyeFilter;

            photoProcessor.Process("path", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye filter");
        }
    }
}