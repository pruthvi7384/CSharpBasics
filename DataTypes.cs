using System;

namespace first_app
{

    /**
    * Data Types
    */
    class DataTypes
    {
        public void dataType()
        {
            //int a = 20;
            //int b = 20;
            //int c = 20;

            //int a = 20,
            //    b = 20,
            //    c = 20;

            int a;
            a = 25;
            Console.WriteLine(a);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            long bigNumber = 90000000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            double doubleNumber = -25.25D;
            Console.WriteLine(doubleNumber);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            float floatNumber = 5.00000F;
            Console.WriteLine(floatNumber);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal decimalNumber = 25.14M;
            Console.WriteLine(decimalNumber);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
        }
    }
}

