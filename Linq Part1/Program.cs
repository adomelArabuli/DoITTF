using System.Collections;
using System.Linq.Expressions;
using System.Threading.Channels;

namespace Linq_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lambda expressionis shua nawilis mere gavagrdzelot
            // LINQ(Language integrated query) F#, VB.Net
            // Syntax: 1) Query syntax 2) Method syntax
            // Query syntax starts with from keyword, ends with select or groupBy keyword

            //string[] names = { "nana", "nini", "giorgi", "erekle", "demetre" };

            //var query = from name in names
            //            where name.Contains("e")
            //            select name;

            Student[] studentArray = {
            new Student() { StudentId = 1, StudentName = "John", Age = 18 },
            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 },
            //new Student() { StudentId = 4, StudentName = "Ram" , Age = 14 },
            new Student() { StudentId = 5, StudentName = "Ron" , Age = 16 },
            new Student() { StudentId = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentId = 7, StudentName = "Bill",  Age = 30 },
            new Student() { StudentId = 8, StudentName = "Rob",Age = 12  },
            };

            //var students = StudentExtension.Where(studentArray, delegate (Student student)
            //{
            //    return student.Age > 13 && student.Age < 18;
            //});

            //var result = studentArray.Where(student => student.Age > 13 && student.Age < 18);

            //var ram = studentArray.Where(s => s.StudentName == "Ram").SingleOrDefault();

            //Student[] teenAgerStudents = new Student[10];
            //int i = 0;
            //foreach (var item in studentArray)
            //{
            //    if (item.Age > 13 && item.Age < 18)
            //    {
            //        teenAgerStudents[i] = item;
            //        i++;
            //    }
            //}

            // delegate


            //var query = from student in studentArray
            //            where student.Age > 13 && student.Age < 18
            //            select student;

            //var methodSyntax = studentArray.Where(s => s.Age > 13 && s.Age < 18);

            var methodSyntax = studentArray.Where((s,youngAge) => s.Age > youngAge);
            IsYoungerThan isYoungerThan = ((s, youngAge) => s.Age > youngAge);
            IsYoungerThan1 withoutParameters = () => Console.WriteLine("test");

            var result = isYoungerThan(studentArray[0], 12);
            Student[] res = new Student[10];
            int i = 0;
            foreach ( var student in studentArray )
            {
                if (isYoungerThan(student, 12))
                {
                    res[i] = student;
                    i++;
                }
            }

        }
    }

    delegate bool IsYoungerThan(Student student, int minAge);
    delegate void IsYoungerThan1();

    delegate bool FindStudent(Student student);
    class StudentExtension
    {
        public static Student[] Where(Student[] students, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach (var item in students)
            {
                if (del(item))
                {
                    result[i] = item;
                    i++;
                }
            }
            return result;
        }
    }
}

public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
