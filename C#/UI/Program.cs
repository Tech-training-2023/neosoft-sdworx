using Comparison;

CarOperations opr = new CarOperations();

var cars=opr.GetAllCars(); 

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