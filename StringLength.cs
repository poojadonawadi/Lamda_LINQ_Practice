using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression_And_LINQ_Practice
{
    internal class StringLength
    {
        public static List<string> GetList()
        {
            List<string> strings = new List<string>() { "Csharp", "Java", "JavaScript", "Python", "C++" };
            return strings;
        }
        //Using lambda Expression
        public static void FilterByLength()
        {
            try
            {
                //filter the string length greater than 5
                List<string> strings = new List<string>() { "Csharp", "Java", "JavaScript", "Python", "C++" };

                List<string> str = strings.FindAll(s => s.Length >= 5).ToList();
                foreach (string word in str)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Using LINQ Syntax
        public static void FilteByLengthLINQ()
        {
            try
            {
                List<string> names = (from words in GetList()
                                      where words.Length >= 5 select words)
                                      .ToList();
                foreach(string elements in names)
                {
                    Console.WriteLine(elements);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


