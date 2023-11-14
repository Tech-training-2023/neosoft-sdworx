using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    struct Employee
    {
        public int Id;
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public decimal salary;

        public string GetDetails()
        {
            return $"{Id} - {firstName} {lastName}, is age - {age} years old, comes from {city} and earns {salary}/month";
        }
    }
}
