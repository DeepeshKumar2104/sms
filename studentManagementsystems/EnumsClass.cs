using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementsystems
{
    public enum SchoolClass
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5,
        Sixth = 6,
        Seventh = 7,
        Eighth = 8,
        Ninth = 9,
        Tenth = 10,
        Eleventh = 11,
        Twelfth = 12
    }
    // Enums method for taking class inputs -- just method implementations and main input proccess in AddStudent() method 
    public class EnumImplementations
    {
        public void EnumClass()
        {
            foreach(var enumclasses in Enum.GetValues(typeof(SchoolClass)))
            {
                Console.WriteLine($"{(int)enumclasses} - {enumclasses}");
            }
        }
    }
}