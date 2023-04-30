using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace _7._safe_password_gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int max  = int.Parse(Console.ReadLine());

            int count = 0;

                           
                    
                    for (int i = 35, j = 64, k = 1, l = 1; ; i++, j++, k++)
                    {
                        
                        
                            Console.Write($"{(char)i}{(char)j}{l}{k}{(char)j}{(char)i}|");
                            if (i == 55) i = 34;
                            if (j == 96) j = 63;

                            if ((l == a) && (k == b)) break;
                            if (k == b) {k = 0; l++;}

                            count++;

                            if (count == max) break;
                        
                    }
                
            
        }
    }
}
