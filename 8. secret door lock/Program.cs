using System;

namespace _8._secret_door_lock
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                int a1 = 0; int b1 = 0; int c1 = 0; int bbindex = 0;

                if (a % 2 == 0) { a1 = a; }
                else a1 = a - 1;

                if (c % 2 == 0) { c1 = c; }
                else c1 = c - 1;

                int[] bb = { 2, 3, 5, 7 };

                // to determine max index in bb, when bb[i] still < 'b'

                for (int i = 0; i < bb.Length; i++)
                {
                    if (bb[i] > b) { bbindex = i - 1; break; }
                    if (bb[i] == b) { bbindex = i; break; }
                    else bbindex = 3;
                }

                // codes printing
                for (int i = 2; i <= a1; i = i + 2)
                {
                    for (int j = 0; j <= bbindex; j++)
                    {
                        for (int k = 2; k <= c1; k = k + 2) { Console.WriteLine($"{i} {bb[j]} {k}"); }
                    }
                }

            }
        
    }
}
