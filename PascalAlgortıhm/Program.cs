using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int n = 6; 

            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("  ");
                }


                int number =1; 

                
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + "   ");
                    number = number * (i - j) / (j + 1); 
                }

                Console.WriteLine(); 
            }
        }
    }
}

