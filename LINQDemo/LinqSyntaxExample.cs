using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class LinqSyntaxExample
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 28, 31, 17, 16, 42 };

            var numsQuery = from n in numbers
                            where n > 20
                            select n;
            Console.WriteLine("Numbers above 20");
            foreach (var item in numsQuery)
            {
                Console.WriteLine(item);
            }
            
            var numsMethod = numbers.Where(n => n < 20);

            Console.WriteLine("Numbers below 20");
            foreach (var item in numsMethod)
                Console.WriteLine(item);

            //combination of query and method syntax
            Console.WriteLine("Total numbers in the array");
            var numsCombined = (from n in numbers
                            select n).Count();
            Console.WriteLine(numsCombined);
        }
    }
}
