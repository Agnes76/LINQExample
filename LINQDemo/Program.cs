using System;
using static LINQDemo.DelegateExample;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extension method
            string str = "Hello World";
            int m = str.WordCount();
            int n = str.LetterCount();
            Console.WriteLine(m);
            Console.WriteLine(n);

            //Delegate is pointing to
            powerDelegate dlgSquare = Square;

            float k = dlgSquare.Invoke(8);
            Console.WriteLine(k);

            powerDelegate dlgCube = Cube;

            float c = dlgCube(8);
            Console.WriteLine(c);

            // del as a call-back
            float res;
            float typ;
            res = Calculate(5, Square);
            Console.WriteLine(res);
            
            typ = Calculate(5, Cube);
            Console.WriteLine(typ);

            // callback method using lambda expression
            res = Calculate(5, r => { return r * r * 3.14F; });
        }
    }
}
