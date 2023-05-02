using System;

namespace _9._sum_of_two_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int count = 0;
            bool stopflag = false;
            int i1 = 0;
            int j1 = 0;

            for (int i = a; i <= b; i++) 
            {
                if (stopflag == true) { break; };
                for (int j = a; j <= b; j++) 
                { 
                    count++;
                    if (i + j == c) { stopflag = true; i1 = i; j1 = j; break; };
                }
            }

            if (stopflag == false)
            {
                Console.WriteLine($"{count} combinations - neither equals {c}");
            }

            else { Console.WriteLine($"Combination N:{count} ({i1} + {j1} = {c})"); }
        }
    }
}

