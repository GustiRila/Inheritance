using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mike", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Teacher", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Students students = new Students("Sara", 19, "10506", "sara1234@amikom.ac.id");
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
