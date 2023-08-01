namespace t02_08_DynamicBinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reflection
            object obj = "Jugoslav";
            //obj.GetHashCode();

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            // Dynamics
            dynamic excellObject = "Jugoslav";
            excellObject.Optimize();

            dynamic name = "Jugoslav";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}