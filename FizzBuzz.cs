using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class FizzBuzz
    {
        public void fizzBuzz()
        {
            for(int i = 1; i <= 15; i++)
            {
                if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i%5 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
