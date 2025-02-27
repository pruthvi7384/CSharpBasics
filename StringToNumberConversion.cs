using System;

namespace first_app
{
    class StringToNumberConversion
    {
        public void stringToNumberConversion()
        {
            string a = "25";
            Console.WriteLine(Convert.ToInt32(a));

            string bigNumber = "90000000000";
            Console.WriteLine(Convert.ToInt64(bigNumber));

            string doubleNumber = "-25.25";
            Console.WriteLine(Convert.ToDouble(doubleNumber));

            string floatNumber = "5.00000";
            Console.WriteLine(Convert.ToString(floatNumber));

            string decimalNumber = "25.14";
            Console.WriteLine(Convert.ToDecimal(decimalNumber));
        }
    }
}
