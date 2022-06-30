using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class LinqExamples
    {
        // not allowed to use var as a field type in class level
        //e.g var name = "grp"
        public void AnonymousType()
        {
            var course = new { Id = 200, Name = "Linq", Duration = 10 };  // show anonymous type         
        }

        public void ImplicitlyType()
        {
            var max = 100; // this type is integer

            var name = "Agnes";  // this type is string

            /*
             1.You cannot declare implicitly typed variable without initialization
            e.g var temp;

            2. Not allowed to declare multiple var in a single statement
            e.g var a= 3, b=5, c=6;
            
           this is allowed: int a = 5, b = 6;

            3. Not allowed to use null 
            e.g var x = null

            these are allowed:
             string sentence = null;
            int? x = null;

            4. Not allowed to initialize implicitly typed variable with different types more than one type
               var sum = 100;
               sum = 10.10;

              var sum = 10;
            sum = (var)10.10;

            this is allowed:
             int sum = 10;
            sum = (int)10.10;
            */
        }
    }
}
