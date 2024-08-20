using StudentManagementSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementsystems
{
    public class StudentManagementSystem
    {
        ViewAllStudentMethod viewAllStudentMethod = new ViewAllStudentMethod();
        AddStudentDisplayInfo msgDisplay = new AddStudentDisplayInfo();
        EnumImplementations enms = new EnumImplementations();
        public void AddStudent(List<StudentClass> students)
        {
            // Behind inputs and logic in (AddStudentDisplay class)
            msgDisplay.MessageDisplay(students);
        }
        public void ViewAllstudents(List<StudentClass> students)
        {
            try
            {
                int count = 0;
                if (students == null || students.Count <= 0)
                {
                    throw new Exception("No Students are present in our list to display");
                }

                viewAllStudentMethod.ViewStudentsList(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exceptions generated {ex.Message}");
            }
        }

        public void FilterByTag(List<StudentClass> students)
        {
            try
            {
                Console.WriteLine("Choose press 1 to 7 to perform desired operations");
                while (true)
                {
                    MessageClass.FilteringBYproperty();
                    Console.WriteLine("Enter 0 ) to exit from the operations");
                    int userchoice = int.Parse(Console.ReadLine());
                    if (userchoice == 0)
                        break;
                    int count = 0;
                    bool found = false;
                    switch (userchoice)
                    {
                        case 1:
                            Console.WriteLine("Enter the FirstName to Check in the list");
                            string firstName = Console.ReadLine();

                            foreach (var stud in students)
                            {
                                if (stud.FirstName.ToLower() == firstName.ToLower())
                                {
                                    viewAllStudentMethod.ConditionPrint(stud, count);
                                    found = true;
                                }
                                count++;
                            }
                            if (!found)
                            {
                                Console.WriteLine("No one is present with Associated names");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter the LastName to Check in the list");
                            string lastName = Console.ReadLine();

                            foreach (var stud in students)
                            {
                                if (stud.LastName.ToLower() == lastName.ToLower())
                                {
                                    viewAllStudentMethod.ConditionPrint(stud, count);
                                    found = true;
                                }
                                count++;
                            }
                            if (!found)
                            {
                                Console.WriteLine("No one is present with Associated names");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter the class to see the students list Bellow");
                            enms.EnumClass();
                            SchoolClass enumsclass = (SchoolClass)int.Parse(Console.ReadLine());
                            foreach (var stud in students)
                            {
                                if (stud.Class == enumsclass)
                                {
                                    viewAllStudentMethod.ConditionPrint(stud, count);
                                    found = true;
                                }

                                count++;
                            }
                            if (!found)
                            {
                                Console.WriteLine("No one is present with Associated Class");
                            }
                            break;
                        case 4:
                            Console.WriteLine(
                                "Enter a subjects based on which filter the students"
                            );
                            string subjects = Console.ReadLine();
                            foreach (var stud in students)
                            {
                                if (stud.Subjects.ContainsKey(subjects))
                                {
                                    viewAllStudentMethod.ConditionPrint(stud, count);
                                    found = true;
                                }
                                count++;
                            }
                            if (!found)
                            {
                                Console.WriteLine("No one is present with Associated Subjects");
                            }
                            break;
                        case 5:
                            Console.WriteLine(
                                "Enter the address to search the number of the students"
                            );
                            string address = Console.ReadLine();
                            foreach (var stud in students)
                            {
                                if (address.ToLower() == stud.Address.ToLower())
                                {
                                    viewAllStudentMethod.ConditionPrint(stud, count);
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                Console.WriteLine("No one is present with Associated Adsress");
                            }
                            break;
                        case 6:
                            Console.WriteLine(
                                "Enter the hobby to search the number of the students"
                            );
                            string hobby = Console.ReadLine();
                            foreach (var stud in students)
                            {
                                if (stud.Hobbies.Contains(hobby))
                                {
                                    viewAllStudentMethod.ConditionPrint(stud, count);
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                Console.WriteLine("No one is present with Associated Hobbies");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void FilterbyAge(List<StudentClass> students)
        {
            Console.WriteLine("Details of the student Age from 15 to 25 ");

            int count = 0;
            bool found = false;
            foreach (var stud in students)
            {
                if (stud.Age >= 15 && stud.Age <= 25)
                {
                    viewAllStudentMethod.ConditionPrint(stud, count);
                    found = true;
                }
                count++;
            }
            if (!found)
            {
                Console.WriteLine("No student present with provided ages");
            }
        }



        // Find the details of the student who is topper of the class.
        public void TopperByClass(List<StudentClass> students)
        {
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("No students are present to evaluate.");
                return;
            }

            Console.WriteLine("Enter the class number (1 for Class1, 2 for Class2, etc.) to find the topper:");
            enms.EnumClass(); // Enum display karne ke liye
            SchoolClass selectedClass = (SchoolClass)int.Parse(Console.ReadLine());

            int highestMarks = int.MinValue;
            StudentClass topper = null;

            foreach (var stud in students)
            {
                if (stud.Class == selectedClass)
                {
                    int totalMarks = 0;
                    bool allSubjectsAbove23 = true;

                    foreach (var sub in stud.Subjects)
                    {
                        if (sub.Value < 23)
                        {
                            allSubjectsAbove23 = false;
                            break;
                        }
                        totalMarks += sub.Value;
                    }

                    if (allSubjectsAbove23 && totalMarks > highestMarks)
                    {
                        highestMarks = totalMarks;
                        topper = stud;
                    }
                }
            }

            if (topper != null)
            {
                Console.WriteLine($"Topper of Class {selectedClass}:");
                Console.WriteLine($"Name: {topper.FirstName} {topper.MiddleName} {topper.LastName}");
                Console.WriteLine($"Total Marks: {highestMarks}");
                Console.WriteLine($"Subjects and Marks:");
                foreach (var sub in topper.Subjects)
                {
                    Console.WriteLine($"  {sub.Key}: {sub.Value}");
                }
                Console.WriteLine($"Hobbies: {string.Join(", ", topper.Hobbies)}");
                Console.WriteLine($"Address: {topper.Address}");
            }
            else
            {
                Console.WriteLine($"No topper found for Class {selectedClass}.");
            }
        }

        public void NthRollNo(List<StudentClass> students) 
        {

        }

        public void DisplayinEvery10sec(List<StudentClass> students) 
        {
            while (true)
            {
                ViewAllstudents(students);
                Thread.Sleep(10000);
            }
        }
        public void DisplayingThreads(List<StudentClass> students)
        {
            Thread displaythreads = new Thread(() => DisplayinEvery10sec(students));
            displaythreads.IsBackground = true; 
            displaythreads.Start();
        }
    }
}
