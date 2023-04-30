using System;
using System.IO;

namespace _6._wedding_seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char area = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int seat = int.Parse(Console.ReadLine());

            int char1 = area;
            int letter = 0;
            int counter = 0;
            

          
            for (int i = 65; i <= char1; i++) 
            {
                for (int j = 1; j <= num+letter; j++) 
                {
                    if (j % 2 == 1)
                    {
                        for (int k = 97; k < 97 + seat; k++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)k}"); counter++;
                        }
                    }
                    else
                    {
                        for (int k = 97; k < 97 + seat+2; k++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)k}"); counter++;
                        }

                    }


                }
                letter++;
            }
            Console.WriteLine(counter);
        }
    }
}
