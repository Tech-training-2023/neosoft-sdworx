using System.IO;
using System.Text.Json;
using EmployeeLibrary;


EmployeeOperations operations = new EmployeeOperations();
var employeesList = operations.Init();
operations.AddDummyEmployees(employeesList);
