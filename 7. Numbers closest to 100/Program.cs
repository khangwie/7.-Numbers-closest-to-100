using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Numbers_closest_to_100
{
    internal class Program
    {
        static int ClosestTo100(int num1, int num2)
        {
            int diff1 = Math.Abs(100 - num1);
            int diff2 = Math.Abs(100 - num2);

            if (diff1 < diff2)
            {
                return num1;
            }
            else if (diff2 < diff1)
            {
                return num2;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int[,] testCases = {
            {78, 95},
            {95, 95},
            {99, 70}
        };

            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                int num1 = testCases[i, 0];
                int num2 = testCases[i, 1];

                int result = ClosestTo100(num1, num2);
                Console.WriteLine(result);
                Console.ReadLine();
            }    }
    }
}
