//predefined namespace : pre-written by C# experts 
global using static System.Console;
using EmployeeLib;
//user defined namespace
namespace HelloWorld; // file scope namespace
                      // Types - class is a type just like structs, enums, delegats, interface, Tuple, records


class Program
{
    static void Main()// starting point of execution, called by CLR
    {
        /*Greeting obj = new Greeting();
        string output = obj.PrintHello("Kartar", "Deoora", 34, 400); // calling/invoking method
        WriteLine(output);
        WriteLine(output.WordCount());*/

        //AnotherClass ac = new AnotherClass();
        //ac.JaggedArrays();

        //tuples
        //(int, float) t1 = (10, 11.2f);
        //WriteLine($"Tuple t1 has elements {t1.Item1} and {t1.Item2}");

        //(int a, float b) t1 = (10, 11.2f);
        //t1.a = 55;
        //WriteLine($"Tuple t1 has elements {t1.a} and {t1.b}");
        //WriteLine(t1.ToString());

        //var tp1 = (a: 6, b: 7.5);
        //var a = 6;
        //var b= 7.4;
        //var tp1 = (a, b); //tuple projection initializers
        //WriteLine(tp1.a);
        //var tp4 = (7, 8.9);
        //tp1 = tp4;
        //var tp2 = (a, b: 4.5f, 77);
        //WriteLine($" The new tuple is ( {tp2.a}, {tp2.b}, {tp2.Item3})");

        //var tp3 = (6, 7.4);
        //WriteLine($"tp1 is equal to tp3 - {tp1==tp3}");
        // using tuple as return type of method
        /*Greeting greeting=new Greeting();
        int[] input = { 5, 20, 6, 14 };
        var minMax = greeting.FindMinMaxValue(input);
        WriteLine($"Min and max value in [{string.Join(", ", input)}] are {minMax.min} and {minMax.max} respectively.");
        */


        // Structs
        //Employee employee = new Employee(100, "James", "Bond",45,"London", 10000.0M );
        Employee employee = new Employee();
        //employee.id = 102;
        //employee.firstName = "Carolyn";
        //employee.lastName = "Rehm";
        //employee.city = "Dallas";
        //employee.age = 28;
        //employee._Salary = 4000.00M;
        //employee.department = Department.IT;
        WriteLine(employee.GetDetails());

        //Employee employee2 = default(Employee); 
        //WriteLine(employee2.GetDetails());
    }
}
// this will not be allowed if you use file scoped namespace before
/*namespace RestaurantReviews
{
    namespace Reviews
    {

    }

}*/