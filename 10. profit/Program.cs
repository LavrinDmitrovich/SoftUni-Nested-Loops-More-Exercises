using System;
using System.Threading;

namespace _10._profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int .Parse(Console.ReadLine());
            int c = int .Parse(Console.ReadLine());

            int d = int .Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i <= a; i++) 
            {
                for (int j = 0; j <= b; j++) 
                {
                    for (int k = 0; k <= c; k++) 
                    {
                        if (i + j * 2 + k *5 == d) 
                            
                        Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {d} lv.")    ; 
                    }
                }
                
            }
        }
    }
}
