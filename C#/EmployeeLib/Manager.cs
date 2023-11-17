using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public enum Perks
    {
        HRA = 1500,
        Travel=2000,
        Meals=200,
        Journals=50
    }
    public class Manager:Employee
    {
        public Perks _Perks { get; set; }
        public List<int> Reportees { get; set; }

        //Method Overriding - redefining the method of base call in child class. Its also known as Dynamic polymorphism
        public override decimal MonthlySalary(decimal WageRate)
        {
            decimal perks = (int)Perks.HRA+ (int)Perks.Journals+(int)Perks.Meals;
            return base.MonthlySalary(WageRate)+perks;//base keyword is used to call any member of the base class
        }

        public List<Manager> GetManagers()
        {
            List<Manager> managers = new List<Manager>()
            {
                new Manager(){Id=11, FirstName="Kartar", LastName="Deoora", City="London", Department=Department.Delivery,
                    DOB=new DateOnly(1989,3,2), Experience=12, Reportees=new List<int>(){ 1,3,4}, WageRate = 200.00M },
                new Manager(){Id=12, FirstName="Simran", LastName="Kaur", City="Delhi", Department=Department.Technology,
                    DOB=new DateOnly(1998,4,29), Experience=3, Reportees=new List<int>(){ 5,6}, WageRate = 250.00M }
            };
            return managers;
        }
        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} - {Department} {City} - ${MonthlySalary(WageRate)}/month, {Experience} years, has {Reportees.Count} employees reporting";
        }
    }
    
}
