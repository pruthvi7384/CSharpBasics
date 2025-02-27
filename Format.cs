using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class Format
    {
        public void format()
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0} {1}", value, "100"));
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));

            double monay = -10D / 3D;

            Console.WriteLine(string.Format("R{0:0.0}", monay));

            Console.WriteLine(monay.ToString("C"));
            Console.WriteLine(monay.ToString("C0"));
            Console.WriteLine(monay.ToString("C1"));
            Console.WriteLine(monay.ToString("C2"));

            Console.WriteLine(monay.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(monay.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
        }

    }
}
