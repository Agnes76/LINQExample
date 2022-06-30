using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class DelegateExample
    {
        public delegate float powerDelegate(float x);

        //make the methods static cos static main method can only access static data
        public static float Square(float n)
        {
            return n * n;
        }

        public static float Cube(float n)
        {
            return n * n * n;
        }

        //call-back method
        public static float Calculate(float n, powerDelegate del)
        {
            float res;
            res = del(n);
            return res;
        }
    }
}
