namespace t02_07_NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);

            DateTime? date1 = new DateTime(2014, 1, 1);
            DateTime date2 = date.GetValueOrDefault();

            DateTime date3;
            if (date != null)
            {
                date3 = date.GetValueOrDefault();
            }
            else
            {
                date3 = DateTime.Today;
            }

            DateTime date4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
            DateTime date5 = date ?? DateTime.Today;
        }
    }
}