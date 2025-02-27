using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class StringOperations
    {
        public void stringOperations()
        {
            Console.Write("Enter the string: ");

            string name = Console.ReadLine();

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please verify your message! \n{0}", name);

                Console.WriteLine($"Please verify your message! \n{name}");

                bool nameValidation = name.Equals("PRUTHVI") ? true : false;

                Console.WriteLine("Name validation: {0}", nameValidation);
            }
            else
            {
                Console.WriteLine("Validate the message!");
            }
        }

        public void reverseString()
        {
            Console.Write("Enter the your message: ");
            string message = Console.ReadLine();

            if (string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Message should be valid!");
            }
            else
            {
                for (int i = message.Length - 1; i >= 0; i--)
                {
                    Console.Write(message[i]);
                }
            }
        }
    }
}
