using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class ConditionalStatment
    {
        public void conditionalStatment()
        {
            //string a, b;

            //Console.WriteLine("Enter the first number: ");
            //a = Console.ReadLine();

            //Console.WriteLine("Enter second number: ");
            //b = Console.ReadLine();

            //if(Convert.ToInt16(a) == Convert.ToInt16(b))
            //{
            //    Console.WriteLine("Nice both values are same!!");
            //}
            //else
            //{
            //    Console.WriteLine("Oh! you miss values is not matching...");
            //}

            Console.WriteLine("Enter day of the week: ");
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2: Console.WriteLine("Tue");
                    break;
                case 3: Console.WriteLine("Wed");
                    break;
                case 4: Console.WriteLine("Thu");
                    break;
                case 5: Console.WriteLine("Fri");
                    break;
                case 6: Console.WriteLine("Sat");
                    break;
                case 7: Console.WriteLine("Sun");
                    break;
                default: Console.WriteLine("Please enter valid number in between 1 to 7 ");
                    break;
            }
      
        }
    }
}
