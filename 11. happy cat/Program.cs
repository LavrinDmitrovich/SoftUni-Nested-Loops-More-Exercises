using System;
using System.Threading;

namespace _11._happy_cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double cost = 0;
            double total =0;

            for (int i = 1; i <= days; i++) 
            {
                for (int j = 1; j <= hours; j++)
                {
                    if ((i % 2 == 0) && ((j + 1) % 2 == 0)) { cost += 2.5; }
                    if (((i + 1) % 2 == 0) && (j % 2 == 0)) { cost += 1.25; }

                    if ((i % 2 == 0) && (j % 2 == 0)) { cost += 1; }
                    if (((i + 1) % 2 == 0) && ((j+1) % 2 == 0)) { cost += 1; }


                }

                Console.WriteLine($"Day: {i} - {cost:f2} leva"); total += cost; cost= 0; 
            }
            Console.WriteLine($"Total: {total:f2} leva");
            
        }
    }
}
