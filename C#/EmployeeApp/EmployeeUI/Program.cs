using System.IO;
using System.Text.Json;
using EmployeeLibrary;

SearchEmployeesByLastName();
ReadEmployees();
SearchEmployeeById();
/*EmployeeOperations operations = new EmployeeOperations();
var employeesList = operations.Init();
AddNewEmployee(employeesList);
operations.AddDummyEmployeesJson(employeesList);*/

static void SearchEmployeeById()
{
    Console.Write("Please enter the id of the employee to be searched ");
    int id = Int32.Parse(Console.ReadLine());
    EmployeeOperations operations = new EmployeeOperations();
    var e = operations.GetEmployeeById(id);
    if (e != null)
        Console.WriteLine($"{e.Id} - {e.FirstName} {e.LastName} - {e.Gender} - {e.City} - ${e.WageRate}/hour");
    else
        Console.WriteLine($"Employee with last name = {id} not found");
}
static void SearchEmployeesByLastName()
{
    Console.Write("Please enter the last name of the employee to be searched ");
    string lastName = Console.ReadLine();
    EmployeeOperations operations = new EmployeeOperations();
    var emp = operations.GetEmployeeByLastName(lastName);
    if (emp != null)
    {
        foreach (var e in emp)
        {
            Console.WriteLine($"{e.Id} - {e.FirstName} {e.LastName} - {e.Gender} - {e.City} - ${e.WageRate}/hour");
        }
    }
    else
        Console.WriteLine($"Employee with id = {lastName} not found");
}
static void ReadEmployees()
{
    EmployeeOperations employeeOperations = new EmployeeOperations();
    var employees = employeeOperations.GetAllEmployees(EmployeeOperations.pathJson);
    foreach (var e in employees)
    {
        Console.WriteLine($"{e.Id} - {e.FirstName} {e.LastName} - {e.Gender} - {e.City} - ${e.WageRate}/hour");
    }
}
static void AddNewEmployee(List<Employee> list)
{
    Employee employee = new Employee();
    Console.Write("Please add employee Id ");
    employee.Id = Int32.Parse(Console.ReadLine());
    Console.Write("Please add employee first name ");
    employee.FirstName = Console.ReadLine();
    Console.Write("Please add employee last name ");
    employee.LastName = Console.ReadLine();
    Console.Write("Please add employee gender ");
    employee.Gender = Char.Parse(Console.ReadLine());
    Console.Write("Please add employee city ");
    employee.City = Console.ReadLine();
    Console.Write("Please add employee wage rate ");
    employee.WageRate = Decimal.Parse(Console.ReadLine());
    list.Add(employee);
}