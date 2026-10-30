using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_Language.Tutorial6
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }
    }

    internal class p6_12
    {
        public static void program()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Yash", Course = "B-Tech", Marks = 85 },
                new Student { Id = 2, Name = "Diya", Course = "MCA", Marks = 65 },
                new Student { Id = 3, Name = "Marmik", Course = "BE", Marks = 75 }
            };

            var result = from s in students
                         where s.Marks > 70
                         orderby s.Marks
                         select s;

            Console.WriteLine("Students having marks greater than 70:\n");

            foreach (Student s in result)
            {
                Console.WriteLine(s.Id + "  " + s.Name + "  " + s.Course + "  " + s.Marks);
            }

            Console.ReadLine();
        }

    }
}