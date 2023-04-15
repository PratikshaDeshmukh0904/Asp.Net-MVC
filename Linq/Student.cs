using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeLinq
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> listStudents = new List<Student>();
            Student student1 = new Student
            {
                ID = 101,
                Name = "Pratiksha",
                Gender = "Female"
            };
            listStudents.Add(student1);

            Student student2 = new Student
            {
                ID = 101,
                Name = "Aarti",
                Gender = "Female"
            };
            listStudents.Add(student2);

            Student student3 = new Student
            {
                ID = 101,
                Name = "Sonu",
                Gender = "male"
            };
            listStudents.Add(student3);

            Student student4 = new Student
            {
                ID = 101,
                Name = "Jeet",
                Gender = "male"
            };
            listStudents.Add(student4);

            Student student5 = new Student
            {
                ID = 101,
                Name = "Akash",
                Gender = "male"
            };
            listStudents.Add(student5);

            return listStudents;
        }
    }
}