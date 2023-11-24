using System;
using Comparison;
using System.Collections;

/*static double Division(double a, double b)
{
    if(b==0)
        throw new DivideByZeroException();
    return a / b;
}
Console.Write("Please enter the numerator ");
double x = double.Parse(Console.ReadLine());
Console.Write("Please enter the denomenator ");
double y = double.Parse(Console.ReadLine());
double result;

try
{
    result = Division(x,y);
    Console.WriteLine($"{x}/{y} = {result}");
    
}

catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
    throw; //rethrowing the exception
}
catch (ArithmeticException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    result = default;
}*/

/*Console.WriteLine("Please enter 2 values to be swapped ");
string a = Console.ReadLine();
string b = Console.ReadLine();
Console.WriteLine($" Swapped values {CommonOperations<string>.Swap(a, b)}");*/


var cars=CarOperations.GetAllCars(); 

Console.WriteLine("Cars unsorted\n");
foreach (Car car in cars)
    Console.WriteLine($"{car.Make}\t\t{car.Year}");

Array.Sort(cars);
Console.WriteLine("\n\nCars default sorted\n");
foreach (Car car in cars)
    Console.WriteLine($"{car.Make}\t\t{car.Year}");

Array.Sort(cars, Car.SortYearAscending());
Console.WriteLine("\n\nCars sorted in ascending order of year\n");
foreach (Car car in cars)
    Console.WriteLine($"{car.Make}\t\t{car.Year}");

Array.Sort(cars, Car.SortYearDescending());
Console.WriteLine("\n\nCars sorted in descending order of year\n");
foreach (Car car in cars)
    Console.WriteLine($"{car.Make}\t\t{car.Year}");
Array.Sort(cars, Car.SortMakeDescending());
Console.WriteLine("\n\nCars sorted in descending order of make");
foreach (Car car in cars)
    Console.WriteLine($"{car.Make}\t\t{car.Year}");
