using System;

namespace _5._challenge_wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int t = int.Parse(Console.ReadLine());

            int n = 0;
            bool stop = false;

           
            
                for (int j = 1; j <= m; j++)
                { if (stop == true) break;
                    for (int k = 1; k <= w; k++) 
                    { 
                        Console.Write($"({j} <-> {k}) "); 
                        n++;
                    if (n == t) { stop = true; break; }
                    }
                }
            
        }
    }
}
