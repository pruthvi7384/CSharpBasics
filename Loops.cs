using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class Loops
    {
        public void loops()
        {
            //Console.Write("What do you want to repeat? ");
            //string message = Console.ReadLine();

            //Console.Write("And how many time do you want? ");
            //int repeater = Convert.ToInt16(Console.ReadLine());

            //for(int i = 0; i < repeater; i++)
            //{
            //    Console.WriteLine(message);
            //}

            Console.Write("Enter the first number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = x * y;

            Console.Write("What was the answer of : " + x + " X " + y + " ? ");
            int userValue = Convert.ToInt32(Console.ReadLine());

            //while(userValue != z)
            //{
            //    Console.WriteLine("Hmm! your one step a head. please try again...");

            //    Console.Write("What was the answer of : " + x + " X " + y + " ? ");
            //    userValue = Convert.ToInt32(Console.ReadLine());
            //}

            do
            {
                Console.WriteLine("Hmm! your one step a head. please try again...");

                Console.Write("What was the answer of : " + x + " X " + y + " ? ");
                userValue = Convert.ToInt32(Console.ReadLine());
            } while (userValue != z);

            Console.WriteLine("WOW ! you did it...");
        }
    }
}
