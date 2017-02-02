using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kari";
            teacher.LastName = "Niemi";
            teacher.Age = 30;
            teacher.Address = "Nakkikatu 666";
            teacher.PhoneNumber = "420420420";
            teacher.Room = "D426";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Kappa", "Ross", "K6666");
            student.Address = "Toritie 69";
            student.Age = 2;
            student.PhoneNumber = "666666666";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
        }
    }
}
