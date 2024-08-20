using StudentManagementSystems;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementsystems
{
    internal class AddStudentDisplayInfo
    {
        EnumImplementations enms = new EnumImplementations();

        public void MessageDisplay(List<StudentClass> students)
        {
            Console.WriteLine("<-----Add a New Student----->");

            string firstName = "";
            while (firstName.Trim() == "")
            {
                Console.WriteLine("Enter the First Name ");
                firstName = Console.ReadLine();
                if (firstName.Trim() == "")
                {
                    Console.WriteLine("First Name should Not be empity");
                }
            }

            // some person mai not have middle name some it will be empty so we are not using validations here
            Console.Write("Enter Middle Name (optional): ");
            string middleName = Console.ReadLine();

            string lastName = "";
            while (lastName.Trim() == "")
            {
                Console.Write("Enter Last Name: ");
                lastName = Console.ReadLine();
                if (lastName.Trim() == "")
                {
                    Console.WriteLine("Last Name should not be empty");
                }
            }

            long age = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Enter the age");
                string input = Console.ReadLine(); 
                try {
                    age = int.Parse(input);
                    if (age >=4 && age <= 25)
                    {
                        isValid = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please provide the valid age ");
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
            }
           
           
            
            Console.Write("Enter Roll No: ");
            long rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Class from 1 to 12th");
            enms.EnumClass();
            SchoolClass enumsclass = (SchoolClass)int.Parse(Console.ReadLine());

            // Subjects implementations
            Dictionary<string, int> subjects = new Dictionary<string, int>();
            Console.WriteLine(
                "Enter the subject with commaa separated numbers (example)------>(Physic,100)"
            );
            Console.WriteLine("if you have filled the subjects then (Types)----->Exit");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                var parts = input.Split(',');
                subjects.Add(parts[0], int.Parse(parts[1]));
            }

            // Hobbbies implementations

            List<string> Hobby = new List<string>();
            Console.WriteLine("Enter your Hobbies ");
            Console.WriteLine("You can add up to 7 hobbies");
            Console.WriteLine("If you have filled the hobbies, type 'exit' to stop.");

            while (true)
            {
                if (Hobby.Count >= 7)
                {
                    Console.WriteLine("You have reached the maximum number of hobbies.");
                    break;
                }

                string hobby = Console.ReadLine();

                if (hobby.ToLower() == "exit")
                {
                    break;
                }

                Hobby.Add(hobby);
            }

            string address = "";
            while (string.IsNullOrWhiteSpace(address))
            {
                Console.Write("Enter Address: ");
                address = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(address))
                {
                    Console.WriteLine("Address cannot be empty. Please enter again.");
                }
            }

            var studentss = new StudentClass(
                firstName,
                middleName,
                lastName,
                age,
                rollNo,
                enumsclass,
                subjects,
                Hobby,
                address
            );
            students.Add(studentss);
        }
    }
}
