using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class VarConstKeyword
    {
        public void varConstKeyword()
        {
            var intNumber = 25;

            var doubleNumber = 2522525;

            var floatNumber = 25.25;

            var decimalNumber = 25.52828;

            var longNumber = 252525252252525;

            Console.WriteLine(intNumber);

            Console.WriteLine(doubleNumber);

            Console.WriteLine(floatNumber);

            Console.WriteLine(decimalNumber);

            Console.WriteLine(longNumber);

            const int a = 50;

            Console.WriteLine(a);

        }
    }
}
