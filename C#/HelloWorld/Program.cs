//predefined namespace : pre-written by C# experts 
global using static System.Console;
using System;
using System.Text;
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
        Employee employee = new Employee();
        employee.Id = 100;
        employee.firstName = "James";
        employee.lastName = "Bond";
        employee.city = "London";
        employee.age = 45;
        employee.salary = 10000.00M;
        WriteLine(employee.GetDetails());
    }
}
// this will not be allowed if you use file scoped namespace before
/*namespace RestaurantReviews
{
    namespace Reviews
    {

    }

}*/