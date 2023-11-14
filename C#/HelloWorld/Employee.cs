using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    struct Employee
    {
        internal int id;
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public decimal salary;

        public Employee()//parameterless constructor
        {
            //default values
            id = 101;
            firstName = "Cartor";
            lastName = "Sen";
            age = 34;
            city = "Slough";
            salary = 7700.00M;
        }
        public Employee(int id, string firstName, string lastName, int age, string city, decimal salary)//parameterized constructor
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.city = city;
            this.salary = salary;
        }
        public string GetDetails()
        {
            return $"{id} - {firstName} {lastName}, is age - {age} years old, comes from {city} and earns {salary}/month";
        }
    }
}
