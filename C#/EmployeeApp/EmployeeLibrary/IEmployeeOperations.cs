using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace EmployeeLibrary
{
    /// <summary>
    /// This interface has declared the methods which can be used to perform operations using methods for an Employee
    /// </summary>
    public interface IEmployeeOperations
    {
        IEnumerable<Employee> GetAllEmployees(string path);
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);

    }
    public class EmployeeOperations : IEmployeeOperations
    {
        static List<Employee> employees = null;
        static string path = @"..\Employee.xml";

        public List<Employee> Init()
        {
            employees = new List<Employee>() { 
                new Employee(){Id=1, FirstName = "Carol", LastName="Baxtor", City="Reston", Gender='F', WageRate=80.10M},
                new Employee(){Id=2, FirstName = "Simran", LastName="Kaur", City="Baroda", Gender='F', WageRate=290.90M},
                new Employee(){Id=3, FirstName = "Cartor", LastName="Dyora", City="London", Gender='M', WageRate=120.00M},
            };
            return employees;
        }

        public void AddDummyEmployees(List<Employee> employees)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(path);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                serializer.Serialize(writer, employees);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
            }
            Console.WriteLine("-----------Employees has been added------------");
        }
        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees(string path)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
