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
    public sealed class Founder { 
    
    }

    //Abstraction through interfaces
    public interface IEmployeeDetails
    {
        List<Employee> GetEmployees();        
    }
    public interface IEmployeeAccount
    {
        decimal MonthlySalary();
    }
    public abstract class EmployeeBase //partial abstraction
    {
        string ssn;
        public abstract List<Employee> GetEmployees();

        public abstract decimal MonthlySalary();
        public string GetDetails()
        {
            return ssn;
        }
    }
    public class Manager:Employee
    {
        public Manager()
        {

        }
        public Manager(string m):base(m)//to call parameterized constructor of the base class
        {

        }
        public Perks _Perks { get; set; }
        public List<int> Reportees { get; set; }

        //Method Overriding - redefining the method of base call in child class. Its also known as Dynamic polymorphism
        public override decimal MonthlySalary()
        {
            decimal perks = (int)Perks.HRA+ (int)Perks.Journals+(int)Perks.Meals;
            return base.MonthlySalary()+perks;//base keyword is used to call any member of the base class
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
            return $"{Id} {FirstName} {LastName} - {Department} {City} - ${MonthlySalary()}/month, {Experience} years, has {Reportees.Count} employees reporting";
        }
    }
    
}
