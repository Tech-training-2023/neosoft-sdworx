using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
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
        public static string pathXml = @"..\..\..\..\Data\Employee.xml";
        public static string pathJson = @"..\..\..\..\Data\Employee.json";

        public List<Employee> Init()
        {
            employees = new List<Employee>() { 
                new Employee(){Id=1, FirstName = "Carol", LastName="Baxtor", City="Reston", Gender='F', WageRate=80.10M},
                new Employee(){Id=2, FirstName = "Simran", LastName="Kaur", City="Baroda", Gender='F', WageRate=290.90M},
                new Employee(){Id=3, FirstName = "Cartor", LastName="Dyora", City="London", Gender='M', WageRate=120.00M},
            };
            return employees;
        }
        /// <summary>
        /// This method add some serialized dummy employees in the Employee.xml file
        /// </summary>
        /// <param name="employees"></param>
        public void AddDummyEmployeesXml(List<Employee> employees)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(pathXml);
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
        /// <summary>
        /// This method add some serialized sample employees to Employee.json file
        /// </summary>
        /// <param name="employees"></param>
        public void AddDummyEmployeesJson(List<Employee> employees)
        {
            using FileStream stream = File.Create(pathJson);
            try
            {
                JsonSerializer.Serialize(stream, employees);

            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("-------------Employees added to Json file---------------");
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine($"Employee {employee.FirstName} has been added");
        }
        /// <summary>
        /// This method reads all employees from Employee.json file by deserializing the data in the file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public IEnumerable<Employee> GetAllEmployees(string path)
        {
            List<Employee> employees= null;
            try
            {
                 employees = JsonSerializer.Deserialize<List<Employee>>(File.ReadAllText(path));
            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            employees = (List<Employee>)GetAllEmployees(pathJson);
            var filteredEmployee = employees.FirstOrDefault(e=>e.Id==id);
            return filteredEmployee;
        }
        public List<Employee> GetEmployeeByLastName(string lastName)
        {
            employees = (List<Employee>)GetAllEmployees(pathJson);
            var filteredEmployee = employees.Where<Employee>(e => e.LastName == lastName).ToList();
            return filteredEmployee;
        }
    }
}
