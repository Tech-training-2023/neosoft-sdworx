//predefined namespace : pre-written by C# experts 
global using static System.Console;
//user defined namespace
namespace HelloWorld; // file scope namespace
                      // Types - class is a type just like structs, enums
class Program
{
    // Type member
    static void Main()// starting point of execution
    {
        //program statment
        /*
         C# is case sensitive
         statements ends with semi-colon
         C# is type safe as well
         */
        WriteLine("Welcome to SDWorx training!");

        //int a;//declaration
        //a = 35; // assigning value

        string a = "35";

        WriteLine(a);

    }
}
// this will not be allowed if you use file scoped namespace before
/*namespace RestaurantReviews
{
    namespace Reviews
    {

    }

}*/