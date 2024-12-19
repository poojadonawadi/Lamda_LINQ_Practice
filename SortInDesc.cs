using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_And_LINQ_Practice
{
    internal class SortInDesc
    {
        public static void GetDescendingOrder()
        {
            try
            {
                List<int> numbers = new List<int>() { 12, 23, 16, 24, 48, 59, 35, 18 };

                List<int> decsOrder = numbers.OrderByDescending(num => num).ToList();

                foreach(int decs in decsOrder)
                {
                    Console.WriteLine(decs);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SortUsingLINQ()
        {
            try
            {
                List<int> integers = new List<int>() { 1, 2, 5, 10, 15, 14 };
                List<int> sortedNumbers = (from num in integers
                                           orderby num descending select num)
                                           .ToList();
                foreach(int item in sortedNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
