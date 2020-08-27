using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WriteLine means that will jump to the next line of code - 
              Console.WriteLine("Hello World");*/

            Console.Write("Hello ");
            Console.WriteLine("World");
            
            /* the \n stops the window and waits for user input*/
            
            Console.WriteLine("\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
