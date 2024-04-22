namespace ConsoleAppProject1ForTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = { };
            int[] arr3 = null;

            MSTestProblems problems  = new MSTestProblems();
            //Console.WriteLine("max value: " + problems.FindMaxValue(arr));
            //Console.WriteLine("max value: " + problems.FindMaxValue(arr2));
            //Console.WriteLine("max value: " + problems.FindMaxValue(arr3));

            // --------------------------------
            //Console.WriteLine(string.IsNullOrEmpty(" "));
            //Console.WriteLine(string.IsNullOrWhiteSpace(" "));

            //Console.WriteLine(char.IsUpper(' ')); // false
            Console.WriteLine("\"\" is upper case: " + problems.StartsWithUpper(""));
            Console.WriteLine("null is is upper case: " + problems.StartsWithUpper(null));
            Console.WriteLine("' ' is upper case: " + problems.StartsWithUpper(" "));
            Console.WriteLine("avd is upper case: " + problems.StartsWithUpper("avd"));
            Console.WriteLine("Avff is upper case: " + problems.StartsWithUpper("Avff"));
            Console.WriteLine("----------------------------");
            Console.WriteLine("ABCis upper case: " + problems.StartsWithUpper("ABC"));
            Console.WriteLine("123 is upper case: " + problems.StartsWithUpper("123"));
            Console.WriteLine("@fj is upper case: " + problems.StartsWithUpper("@fj"));
            Console.WriteLine("'.' is upper case: " + problems.StartsWithUpper("."));
            Console.WriteLine("';' is upper case: " + problems.StartsWithUpper(";"));
            Console.WriteLine("''is upper case: " + problems.StartsWithUpper(string.Empty));

            Console.WriteLine("-------------------");




        }
    }
}
