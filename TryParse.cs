using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class TryParse
    {
        public void tryParse()
        {
            int number;

            while (true)
            {
                Console.Write("Enter the any number: ");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Failed to parse");
                }
            }

            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }
        }
    }
}
