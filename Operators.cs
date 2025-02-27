using System;

namespace first_app
{
    class Operators
    {
        public void operators()
        {
            int a = 0;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);

            int b = 50;
            b *= 2;
            Console.WriteLine(b);

            b /= 2;
            Console.WriteLine(b);

            b -= 2;
            Console.WriteLine(b);

            int firstNumber = 10;
            int secondNumber = 2;

            decimal reminder = firstNumber % secondNumber;
            Console.WriteLine(reminder);
        }
    }
}
