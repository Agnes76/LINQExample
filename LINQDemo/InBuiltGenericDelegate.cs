using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class InBuiltGenericDelegate
    {
        //Func
        public static float TrianglePerimeter(float a, float b, float c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            //addition of 2 numbers
            Func<int, int, int> del1 = (a, b) => a + b; // using lambda expression

            Func<float, float, float> del2 = delegate (float x, float y)
                                              {
                                                 return x * y;
                                              };       // using anonymous method


            Func<float, float, float, float> Tperimeter = TrianglePerimeter; // use with a normal method

            int c = del1(7, 4);
            float res = del2(13.6F, 9.45F);
            float m = Tperimeter(5, 7, 9);

            //Action Delegate
            Action<string> Greet = name => Console.WriteLine("Hello " + name);
            Greet("Ella");

            Action<int> Table = n =>
                                   {
                                       for (int i = 1; i < 10; i++)
                                       {
                                           Console.WriteLine(n * i);
                                       }
                                   };

            Table(8);

            // Predicate Delegate
            Predicate<int> IsPositive = (n) => n > 0;

            Predicate<int> IsEven = n => n % 2 == 0;

            Console.WriteLine(IsPositive(-9));
            Console.WriteLine(IsEven(4));
        }
      
    }
}
