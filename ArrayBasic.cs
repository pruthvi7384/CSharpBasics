using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class ArrayBasic
    {
        public void array()
        {
            int[] arrayInt = new int[] { 1, 10, 5, 5, 8, 2, 82, 69 };

            Console.WriteLine(":::::::: Array Sort :::::::::");

            Array.Sort(arrayInt);

            foreach(int i in arrayInt)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(":::::::: Array Reverse :::::::::");

            Array.Reverse(arrayInt);

            foreach (int i in arrayInt)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(":::::::: Array Clear :::::::::");

            Array.Clear(arrayInt, 0, arrayInt.Length);

            foreach (int i in arrayInt)
            {
                Console.WriteLine(i);
            }

            int[] arraySearch = new int[] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };

            Console.Write("Enter the number what you want to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(arraySearch, search);

            if (position > -1)
            {
                Console.WriteLine($"{search} is found in position {position}");
            }
            else
            {
                Console.WriteLine($"Not found {search}");
            }
          
        }
    }
}
