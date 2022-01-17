using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n1. The sum of the Add method with two integers:");
            Console.WriteLine(Add(17, 45));

            Console.WriteLine($"\n2. The sum of the Add method with two decimals");
            Console.WriteLine(Add(17.45m, 45.17m));

            Console.WriteLine($"\n3. Are these two integers equal to this total amount in 'dollars'?");
            Console.WriteLine(Add(45, 17, true));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            if (isTrue)
            {
                string writtendollar = "dollars";
                return $"\n{num1 + num2} {writtendollar}";
            }
            else
            {
                return $"\nDoesn't make cents! Not equal.";
            }
        }
    }
}
