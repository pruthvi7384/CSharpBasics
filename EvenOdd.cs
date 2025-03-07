using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class EvenOdd
    {
        public void evenOdd()
        {
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if(i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine(":::::: EVEN NUMBERS ::::::::");
            foreach(var i in even)
            {
                Console.Write(i);
            }

            Console.WriteLine("\n:::::: ODD NUMBERS ::::::::");
            foreach (var i in odd)
            {
                Console.Write(i);
            }
        }

        public void multiplication()
        {
            int num = 10;
            int length = 5;
            int[] result = new int[length];

            int counter = 0;

            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = i * num;
            }
        
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }

        }
    }
}
