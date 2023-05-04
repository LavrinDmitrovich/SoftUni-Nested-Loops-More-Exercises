using System;

namespace _12._song_of_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int a=0, b=0, c = 0, d = 0  ;
            bool haveCode = false;

            for (int i = 0; i <=9; i++) 
            {
                for (int j = 0; j <=9; j++) 
                {
                    for (int k = 0; k <=9; k++) 
                    {
                        for (int l = 0; l <=9; l++) 
                        {
                            if ((i < j) && (k > l) && ((i * j + k * l) == num))
                            {
                                Console.Write($"{i}{j}{k}{l} "); 
                                count++; 
                                if (count ==  4) { a = i; b = j; c = k; d = l; haveCode = true; }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

            if (haveCode ==false) { Console.WriteLine("No!"); }

            else Console.Write($"Password: {a}{b}{c}{d}");
        }
    }
}
