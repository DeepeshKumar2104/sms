using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementsystems
{
    public static class MessageClass
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("1. Add a New Student");
            Console.WriteLine("2. Get All Students");
            Console.WriteLine("3. Filter Students");
            Console.WriteLine("4. Find Students by Age Range (15-25)");
            Console.WriteLine("5. Find Class Topper");
            Console.WriteLine("6. Find Nth Topper in Class");
            Console.WriteLine("7. Display Classes with Students (Every 10 Seconds)");
            Console.WriteLine("0. Exit");
            Console.WriteLine("---------------------------------------");
            Console.Write("Please select an option: ");
        }

        // Filter students by different fields like name (obviously first name, middle name, last name), class, subjects, address, hobbies

        public static void FilteringBYproperty()
        {
            Console.WriteLine("Find by First Name...");
            Console.WriteLine("Find by Last Name...");
            Console.WriteLine("Find by Class...");
            Console.WriteLine("Find by Subjects...");
            Console.WriteLine("Find by Address...");
            Console.WriteLine("Find by Hobbies...");
        }
    }
}
