using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class List
    {
        public void list()
        {
            List<String> listString = new List<string>();
            listString.Add("x");
            listString.Add("y");
            listString.Add("z");

            Console.WriteLine("::::::: Initial List ::::::::");
            foreach(String s in listString){
                Console.WriteLine(s);
            }

            listString.Remove("z");

            Console.WriteLine("::::::: Removed 'Z' List ::::::::");
            foreach (String s in listString)
            {
                Console.WriteLine(s);
            }

            listString.Clear();
            Console.WriteLine("::::::: Clear List ::::::::");

            if(listString.Count() < 1)
            {
                Console.WriteLine("List is empty!");
            }

            foreach (String s in listString)
            {
                Console.WriteLine(s);
            }
        }
    }
}
