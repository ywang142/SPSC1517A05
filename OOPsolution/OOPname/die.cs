using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPname
{
    public class die
    {
        // this is the definition of a object
        // it is a conceptual view of the data 
        //   that will be held by a physical 
        //   instance (object) of this class

        // Data Members
        // is an internal private data storage item
        // private data members CANNOT be reached directly by the user
        // public data members CAN be reached directly by the user
        private int _Sides;
        private string _Color;
        private int _faceValue;

        // Properties
        // a property is an external interface between the user and a single piece of data within the instance
        // a property has two abilities
        //      a) the ability to assign a value to the internal data member
        //      b) return a internal data member value to the user

        // Fully Implemented Property
        public int Sides
        {
            // takes internal values and returns it to the user
            get { return _Sides; }
            set
            {
                // takes the supplied user value and places it into the internal private data member
                // the incoming piece of data is placed into a special variable that is called: value
                _Sides = value;
            }
        }
        public string Color
        {
            // takes internal values and returns it to the user
            get { return _Color; }
            set
            {
                // takes the supplied user value and places it into the internal private data member
                // the incoming piece of data is placed into a special variable that is called: value
                _Color = value;
            }
        }
        public int faceValue
        {
            // takes internal values and returns it to the user
            get { return _faceValue; }
            set
            {
                // takes the supplied user value and places it into the internal private data member
                // the incoming piece of data is placed into a special variable that is called: value
                _faceValue = value;
            }
        }
        // Constructors

        // optional; if not supplied the system default constrctor is used which will assign a value to each data member/ auto implement property according to its datatype

        // you can have any number of constrctors within your class as soon as you code a constructor, your program is responsible for all constructors

        // syntax public classname([list of parameters]) {...}

        // typical constructors:
        // Default constructor - this is similiar to the system default constrctor
        public die()
        {
            // you could leave this constructor empty and the system would access the normal default value to your data members and auto implemented properties

            // you can directly access a private data member any place within your class
            _Sides = 6;

            // you can access any property any place within your class
            Color = "white";
        }

        // Greedy Constructor 
        // - typical has a parameter for each data member and auto implement property within your class
        // - parameter order is not important
        // - this constructor allows the outside user to create and assign their own values to the dta members/ auto properties at the time of instance creation
        public die(int sides, string color, int facevalue)
        {
            // since this data is coming from an outside source, it is best to use your property to save the values; specially if the property has validation
            Sides = sides;
            Color = color;
            faceValue = facevalue;
        }


        // Behaviours (methods)

        // these are actions that the class can perform
        // the actions may or may not alter data memebers/auto values
        // the actions could simply take a value from value(s) from the user and perfrom some logic operations against the values
        
        // can be public or private
        // create a method that allows the user to change the number of sides on a die
        public void SetSides(int sides)
        {
            if(sides >= 6 && sides <=20)
            {
                Sides = sides;
            }
            else
            {
                // optionally 
                // a) throw a new exception
                throw new Exception("Invalid value for sides");
                // b) set _Sides to a default value
                // Sides = 6;

            }
        }

    }
}
