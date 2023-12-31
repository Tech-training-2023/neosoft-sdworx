﻿using System;
namespace EmployeeLib
{
    public class Employee :IEmployeeDetails,IEmployeeAccount //:EmployeeBase//:Founder // cannot derive from a sealed class
    {
        public Employee()
        {
            Console.WriteLine("Employee class parameterless Constructor");
        }
        public Employee(string sd)
        {
            Console.WriteLine("Employee class parameterized Constructor");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Experience { get; set; }
        public decimal WageRate { get; set; }
        public string City { get; set; }
        public Department Department { get; set; }
        public DateOnly DOB { get; set; }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>() {
            new Employee(){Id = 1,FirstName = "Jacob", LastName = "Davis",WageRate = 30.0M,City = "Dallas",Experience = 3.5f, Department=Department.Technology, 
                DOB = new DateOnly(1998,11, 7) },
            new Employee(){Id=3,FirstName="Marielle", LastName="Nolasco", Experience=3, WageRate=35.0M, Department=Department.IT, City="Tampa"},
            new Employee(){Id=4,FirstName="Fred", LastName="Smith", Experience=13, WageRate=135.0M, Department=Department.IT, City="Washigton DC"},
            new Employee(){Id=5,FirstName="Brady", LastName="Jacobson", Experience=5, WageRate=75.0M, Department=Department.Technology, City="London"},
            new Employee(){Id=6,FirstName="Tommy", LastName="Beth", Experience=9, WageRate=69.0M, Department=Department.Sales, City="Wales"}
            };
            return employees;
        }
        //public abstract List<string> GetDuties();
        public virtual decimal MonthlySalary()
        {
            return 160 * WageRate;
        }
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} - {Department} {City} - ${MonthlySalary()}/month, {Experience} years.";
        }
    }
}