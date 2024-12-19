using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_And_LINQ_Practice
{
    internal class Calculate
    {
        public static void GetSum()
        {
            try
            {
                List<int> numbers = new List<int>() { 12, 24, 15, 2, 7, 13, 17 };

                int oddSum = numbers.FindAll(x => x % 2 == 1).Sum();

                Console.WriteLine("The sum of odd numbers in the list is :"+ oddSum);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void GetOddSum()
        {
            try
            {
                List<int> numbers = new List<int>() { 12, 24, 15, 2, 7, 13, 17 };

                int getOddSum = (from num in numbers
                                 where num % 2 == 1 select num).Sum();

                Console.WriteLine("The sum of odd numbers in the list is :" + getOddSum);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
