using studentManagementsystems;
using System;
using System.Collections.Generic;

namespace StudentManagementSystems
{
    public class StudentClass
    {
        // Properties of the Student class
        public string FirstName
        {
            get;
            set;
        }
        public string MiddleName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public long Age
        {
            get;
            set;
        }
        public long RollNo
        {
            get;
            set;
        }
        public SchoolClass Class
        {
            get;
            set;
        }
        public Dictionary<string, int> Subjects
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public List<string> Hobbies
        {
            get;
            set;
        }
        public DateTime AddedDateTime
        {
            get;
            set;
        }

        public StudentClass(string firstName, string middleName, string lastName,
                    long age, long rollNo, SchoolClass schoolClass,
                    Dictionary<string, int> subjects, List<string> hobbies, string address) // Added DateTime parameter
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            RollNo = rollNo;
            Class = schoolClass;
            Subjects = subjects;
            Hobbies = hobbies;
            Address = address;
             // Initialize AddedDateTime
        }

    }
}
