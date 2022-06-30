using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class AnonymousExample
    {
        public delegate float PointerTo(float x);

        static void Main(string[] args)
        {
            PointerTo circleArea = delegate (float r)
            {
                return 3.14F * r * r;
            };

            circleArea(7);
            float a = circleArea(7);
        }
    }
}
