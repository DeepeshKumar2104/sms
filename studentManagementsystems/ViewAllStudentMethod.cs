using StudentManagementSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentManagementsystems
{
    internal class ViewAllStudentMethod
    {
        public void ViewStudentsList(List<StudentClass>students)
        {
            int count = 0;
            foreach (var stud in students)
            {
                Console.Write($"{count} FirstName: {stud.FirstName} MiddleName: {stud.MiddleName} LastName: {stud.LastName} Age: {stud.Age} RollNo: {stud.RollNo} Class: {stud.Class}");
                Console.Write("Subjects: ");
                foreach (var sub in stud.Subjects)
                {
                    Console.Write($" {sub.Key}--{sub.Value}");
                }
                Console.Write($"Hobbies : {string.Join(",", stud.Hobbies)}");
                Console.WriteLine($"Address : {stud.Address}");
                count++;
            }
        }
        public void ConditionPrint(StudentClass stud, int count)
        {
            Console.Write($"{count} FirstName: {stud.FirstName} MiddleName: {stud.MiddleName} LastName: {stud.LastName} Age: {stud.Age} RollNo: {stud.RollNo} Class: {stud.Class}");
            Console.Write("Subjects: ");
            foreach (var sub in stud.Subjects)
            {
                Console.Write($" {sub.Key}--{sub.Value}");
            }
            Console.Write($"Hobbies : {string.Join(",", stud.Hobbies)}");
            Console.WriteLine($"Address : {stud.Address}");
            
        }
    }
}
