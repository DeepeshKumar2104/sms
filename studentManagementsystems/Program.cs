// Student Management systems
using studentManagementsystems;
using StudentManagementSystems;
using System.Collections.Generic;
namespace HelloDeepesh
{
    public delegate void StudentDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            StudentManagementSystem studentManagement =
              new StudentManagementSystem(); // Ek list sabke liye
            List<StudentClass> students = new List<StudentClass>();
            Console.WriteLine("<-----------Student Management Systems-------------->");
            while (true)
            {
                try
                {
                    MessageClass.DisplayMenu();
                    int userChoice = int.Parse(Console.ReadLine());

                    if (userChoice <= 7 && userChoice >= 1)
                    {
                        switch (userChoice)
                        {
                            case 0:
                                return;

                            case 1:
                                StudentDelegate studentDelegate =
                                  new StudentDelegate(() => studentManagement.AddStudent(students));
                                studentDelegate.Invoke();
                                Console.WriteLine("Data Added successfully in the lists");
                                break;

                            case 2:
                                studentDelegate = new StudentDelegate(
                                  () => studentManagement.ViewAllstudents(students));
                                studentDelegate.Invoke();
                                break;
                            case 3:
                                studentDelegate = new StudentDelegate(() => studentManagement.FilterByTag(students));
                                studentDelegate.Invoke();
                                break;
                            case 4:
                                studentDelegate = new StudentDelegate(() => studentManagement.FilterbyAge(students));
                                studentDelegate.Invoke();
                                break;
                            case 5:
                                studentDelegate = new StudentDelegate(() => studentManagement.TopperByClass(students));
                                studentDelegate.Invoke();
                                break;
                            case 6:
                                break;
                            case 7:
                                studentDelegate = new StudentDelegate(() => studentManagement.DisplayingThreads(students));
                                studentDelegate.Invoke();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please choose valid number from 1 to 7 ");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}