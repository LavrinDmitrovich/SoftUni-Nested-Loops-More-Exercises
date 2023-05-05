using System;

namespace _14._password_gen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i < a; i++) 
            {
                for (int j = 1; j < a; j++) 
                {
                    for (int k = 97; k <97 + b; k++) 
                    {
                        for (int l = 97; l < 97 + b; l++) 
                        {
                           int s = 0;
                            if (i>j)  s = i;
                            else s = j;

                            for (int m = s+1; m <= a; m++) { Console.Write($"{i}{j}{(char)k}{(char)l}{m} "); }
                        }
                    }
                } 
            }
        }
    }
}
