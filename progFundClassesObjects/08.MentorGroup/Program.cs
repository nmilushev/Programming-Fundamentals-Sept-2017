using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (input != "end of dates")
            {
                var date = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var student = new Student();
                student.Name = date[0];
                student.Data = new List<DateTime>();
                student.Comment = new List<string>();

                for (int i = 1; i < date.Length; i++)
                {
                    student.Data.Add(DateTime.ParseExact(date[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
                if (students.Any(x => x.Name == date[0]))
                {
                    Student exiStudent = students.First(x => x.Name == date[0]);
                    for (int index = 1; index < date.Length; index++)
                    {
                        exiStudent.Data.Add(DateTime.ParseExact(date[index], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    if (exiStudent.Data.Count == 0)
                    {
                        exiStudent.Data = new List<DateTime>();
                        for (int index = 1; index < date.Length; index++)
                        {
                            exiStudent.Data.Add(DateTime.ParseExact(date[index], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                        }
                    }
                }
                else
                {
                    students.Add(student);
                }
                input = Console.ReadLine();

            }

            var comments = Console.ReadLine().Split('-').ToList();
            while (comments[0] != "end of comments")
            {
                var name = comments[0];
                var comment = comments[1];
                if (students.Any(x => x.Name == name))
                {
                    Student exiStudent = students.First(x => x.Name == name);
                    exiStudent.Comment.Add(comment);
                }
                comments = Console.ReadLine().Split('-').ToList();
            }

            foreach (var student in students.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                if (student.Comment.Count > 0)
                {
                    Console.WriteLine("- {0}", string.Join("\r\n- ", student.Comment));
                }
                Console.WriteLine("Dates attended:");
                if (student.Data.Count > 0)
                {
                    foreach (var date in student.Data.OrderBy(x => x.Date))
                    {
                        Console.WriteLine($"-- {date.Date:dd/MM/yyyy}");
                    }
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<string> Comment { get; set; }
        public List<DateTime> Data { get; set; }
    }
}
    

