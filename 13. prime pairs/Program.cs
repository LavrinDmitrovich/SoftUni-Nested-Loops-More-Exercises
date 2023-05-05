using System;

namespace _13._prime_pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            bool first = false;
            bool second = false;

            for (int i = a; i <= a+c; i++) 
            {
                for (int j = b; j <= b+d; j++) 
                {
                
                    for (int k = 2;  k < j; k++) { if ((double)j % k == 0) first = true; }
                    for (int l = 2; l < i; l++) { if ((double)i % l == 0) second = true; }

                    

                    if (first == false && second == false) { Console.WriteLine($"{i}{j}"); }
                    else { first = false; second = false; }
                }
            }
        }
    }
}
