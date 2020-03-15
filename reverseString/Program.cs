using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string forwardString = "";
            string backwardString = "";

            Console.WriteLine("Enter a string: ");
            forwardString = Console.ReadLine();

            foreach (char c in forwardString)
            {
                backwardString = c + backwardString;
            }
            Console.WriteLine(forwardString + " Backwards is: " + backwardString);
            Console.WriteLine("Press Enter to Quit");
            Console.ReadLine();
        }
    }
}
