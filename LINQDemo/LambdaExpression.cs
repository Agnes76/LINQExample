using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public delegate float PointerTo(float x);
    public class LambdaExpression
    {
        static void Main(string[] args)
        {
            PointerTo area = (r) => { return r * r * 3.14F; };

            area(4);

            float s = area(4);
        }
    }
  
}
