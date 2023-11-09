//predefined namespace : pre-written by C# experts 
global using static System.Console;
using System;
using System.Text;
//user defined namespace
namespace HelloWorld; // file scope namespace
                      // Types - class is a type just like structs, enums
class Program
{
    static void Main()// starting point of execution, called by CLR
    {
        Greeting obj = new Greeting();
        string output = obj.PrintHello("Rishi", "Sunak"); // calling/invoking method
        //WriteLine(output);     
        
        AnotherClass ac = new AnotherClass();
        ac.JaggedArrays();
        
    }
}
// this will not be allowed if you use file scoped namespace before
/*namespace RestaurantReviews
{
    namespace Reviews
    {

    }

}*/