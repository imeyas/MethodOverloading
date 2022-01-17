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
            Console.WriteLine(Add(0, 0, true));
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
            Console.WriteLine($"\nWhat is the first dollar amount?");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nWhat is the second dollar amount?");
            num2 = Convert.ToInt32(Console.ReadLine());

            var sum = num1 + num2;
            if (sum >= 0 || sum < 0)
            {
                return $"\n{sum} dollars";
            }
            else
            {
                return $"Invalid input. Try again.";
            }
            
        }
    }
}
