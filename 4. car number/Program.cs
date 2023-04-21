using System;

namespace _4._car_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            bool check4 = false;

            
            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    for (int k = num1; k <= num2; k++)
                    {
                        for (int l = num1; l <= num2; l++)

                        {
                            if ((i%2 == 0) && ( l%2 == 1 )) check1 = true;
                            if ((l % 2 == 0) && (i % 2 == 1)) check2 = true;
                            if (i>l) check3 = true;
                            if ((j+k)%2 == 0) check4 = true;

                            if ((check1 && check3 && check4) || (check2 && check3 && check4)) 
                            { 
                                Console.Write($"{i}{j}{k}{l} ");
                                
                            }
                            check1 = false;
                            check2 = false;
                            check3 = false;
                            check4 = false;
                        }
                    }
                }
            }
        }
    }
}
