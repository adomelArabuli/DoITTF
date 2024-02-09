using System.Collections;
using System.Net.Http.Headers;

namespace Linq_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IsAdult isAdult = (s) =>
            //{
            //    int adultAge = 18;
            //    return s >= adultAge;
            //};

            //var result = isAdult(17);
            IList<Student> studentList = new List<Student>()
            {
                 new Student() { StudentId = 1, StudentName = "John", Age = 13} ,
                 new Student() { StudentId = 2, StudentName = "Moin",  Age = 21 } ,
                 new Student() { StudentId = 3, StudentName = "Bill",  Age = 18 } ,
                 new Student() { StudentId = 4, StudentName = "John" , Age = 20} ,
                 new Student() { StudentId = 5, StudentName = "Bill" , Age = 20} ,
                 new Student() { StudentId = 6, StudentName = "Ron" , Age = 13} ,
                 new Student() { StudentId = 7, StudentName = "Bill" , Age = 20} ,
                 new Student() { StudentId = 8, StudentName = "Ron" , Age = 18 }
             };


            var john = studentList.Single(x => x.StudentName == "Tekla"); // single or singleOrDefault returns only if elements is not dublicated in sequense
            //var orderedByname = studentList.OrderBy(x => x.StudentName).ThenBy(x => x.Age).ToList();

            //var orderedByName = from s in studentList
            //                    orderby s.StudentName
            //                    select s;
            //var reversedList = studentList.Reverse();

            var groupedByName = studentList.GroupBy(x => x.StudentName);
            var groupedByNameUsingLookUp = studentList.ToLookup(x => x.StudentName);
            var groupedByAge = studentList.GroupBy(x => x.Age);
            var groupedByNameAge = studentList.GroupBy(s => new { s.StudentName, s.Age });

            Console.WriteLine();
            //var filteredStudents = from s in studentList
            //                       where s.Age > 12 && s.Age < 20
            //                       select s.StudentName;


            //Func<Student, bool> IsTeenAger = (student) =>
            //{
            //    return student.Age > 12 && student.Age < 20;
            //};
            //List<Student> students = new List<Student>();
            //foreach (var student in studentList )
            //{
            //    if (IsTeenAger(student))
            //    {
            //        students.Add(student);
            //    } 
            //}

            //var fitleredStudents = from s in studentList
            //                       where IsTeenAger(s)
            //                       select s;

            //var methodSyntax = studentList.Where((s, i) =>
            //{
            //    if (i % 2 != 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //});

            //ArrayList item = new ArrayList();
            //item.Add(1);
            //item.Add(50);
            //item.Add(1.1m);
            //item.Add(5.1f);
            //item.Add(true);
            //item.Add(false);
            //item.Add("Test");
            //item.Add("Test1");

            //var stringResult = from i in item.OfType<string>()
            //                   select i;

            //var intResult = from i in item.OfType<int>()
            //                   select i;

            //var boolResult = from i in item.OfType<bool>()
            //                select i;

            //var decimalResult = item.OfType<double>();
        }



        //delegate bool IsAdult(int a);
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

}