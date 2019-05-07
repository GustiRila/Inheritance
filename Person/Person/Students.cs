using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Students : Person
    {
        public string StudentsId { get; set; }
        public string Email { get; set; }

        public Students (string name, int age, string id, string subject) : base (name, age)
        {
            Name = name;
            Age = age;
        }
    }
}
