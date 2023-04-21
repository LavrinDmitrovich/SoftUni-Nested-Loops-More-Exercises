using System;

namespace _2._letters_combination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s1 = char.Parse(Console.ReadLine());
            char s2 = char.Parse(Console.ReadLine());
            char s3 = char.Parse(Console.ReadLine());

            int n1 = s1;
            int n2 = s2;
            int n3 = s3;

            int count = 0;

            for (int i = n1; i <= n2; i++) 
            {
                if (i == n3)  continue; 
                for (int j = n1; j <= n2; j++) 
                {
                    if (j == n3) continue;
                    for (int k = n1; k <= n2; k++) { if (k == n3) continue; Console.Write($"{(char)i}{(char)j}{(char)k} "); count++; }
                }
                    
            }
            Console.WriteLine(count++);

        
        }
    }
}
