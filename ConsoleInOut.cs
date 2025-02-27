using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class ConsoleInOut
    {
        public void consoleInputOutput()
        {
            String name;
            int age;

            Console.Write("Enter your name please: ");
            name = Console.ReadLine();

            Console.Write("Enter your age please: ");
            String inAge = Console.ReadLine();

            age = Convert.ToInt32(inAge);

            Console.WriteLine("Welcome " + name + "!!!" + "\nyour age is : " + age + "\nplease confirm.");
        }
    }
}
