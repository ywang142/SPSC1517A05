using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPname
{
    // Data member

    // Properties - the interface of the instance  for a data member to a user

    // Characteristics - size - int
    //                 - color - string
    //                 - face - int

    // Constructor - use to set up an initial state of your object (instance)

    // Method - actions available to the user

    // Roll() - randomly create a value between min max
    //        - assign to the face property

    // Unstand the problem ----- Design solution ----- codes
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = 123;
            double num2 = 234;
            Console.WriteLine(" ");
            Console.WriteLine($"{number1,-15}{num2,20}");
        }
    }
}
