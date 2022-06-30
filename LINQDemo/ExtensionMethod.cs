using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public static class ExtensionMethod
    {
        public static int WordCount(this string str)
        {
          string[] strArray = str.Split(' ');
            int l = strArray.Length;
            return l;
        }

        public static int LetterCount(this string str)
        {
            char[] charArray = str.ToCharArray();
           int j = charArray.Length;
            return j;
        }
    }
}
