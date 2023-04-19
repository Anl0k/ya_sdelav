using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funco
{
    public class Class1
    {
        public static void SumFunc(string x, string y)
        {
            var a = x.Split(',');
            int sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum = Int32.Parse(a[i]) + sum;
            }

            var b = y.Split(',');
            int mult = 1;

            for (int i = 0; i < b.Length; i++)
            {
                mult = Int32.Parse(b[i]) * mult;
            }
            Console.WriteLine(sum);
            Console.WriteLine(mult);
        }

    }
}
