//predefined namespace : pre-written by C# experts 
global using static System.Console;
using System;
using System.Text;
//user defined namespace
namespace HelloWorld; // file scope namespace
                      // Types - class is a type just like structs, enums
class Program
{
    readonly float pi;
    public Program()
    {
        pi = 3.14f;
    }
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
        //DateTime dt;
        //long a;//declaration
        //a = 35; // assigning value
        /*int c = int.MaxValue;
        unchecked
        {
            WriteLine(c + 2);
        } 
        long x = 922337203685477580;// int is 4 bytes numeric type
        checked
        {
            int y = (int)x; // long is 8 byte numeric type, implicit type conversion
            WriteLine(y);// this will lead to overflow exception
        }  */

        // STRINGS
        /*string a; // declarations
        a = " A fox jumped in to the lake  \row  ";  // intializations
        string path = @"c:\training\neosoft-sdworx
        this path contains training documents and code
        All the best
        Trainer : ""Pushpinder""
            "; // \t and \n are escape sequence characters, verbatim string using @ will ignore them
        WriteLine(path);
        WriteLine(a.Contains("fox"));
        WriteLine(a.ToUpper());
        WriteLine(a.Clone());
        WriteLine(a.Trim());
        

        WriteLine(a.Length);*/

        //int m = Int32.Parse(a);
        //int m = Convert.ToInt32(a);
        //WriteLine(m.GetType());
        /*string s1 = "Neosoft - ";
        string s2 = "sdworx";

        s1 += s2; // s1 = s1 + s2
        WriteLine(s1);*/ // new string is created for s1 because strings are immutable

        /*StringBuilder sb = new StringBuilder("Neosoft - ");
        sb.Append("sdworx");

        WriteLine(sb.ToString());// String Build offers better performance as it creates a string buffer and manipulations are performed on the strings. 
        */
        string firstName = "Pushpinder", lastName = "Kaur", Country = "England";
        //WriteLine("The instructor name is {0} {1} and she is from {2}", firstName, lastName, Country);// composite formatting using String.Format
        WriteLine($"The instructor name is {firstName} {lastName} and she is from {Country}"); // uses string interpolation

        var name = 25.00;//implicitly typed local variable
        WriteLine(name.GetType());
        float pi = 3.14f;
        if (pi > 3)
        {
            WriteLine($"pi == {pi}");
        }
        else
        {
            WriteLine($"Incorrect pi value -> {pi}");
        }


        int marks = 0;
        char grade;
        if (marks > 90)
            grade = 'A';
        else if (marks < 90 && marks > 70)
            grade = 'B';
        else if (marks < 70 && marks > 60)
            grade = 'C';
        else
            grade = 'D';

        int daysOfWeek = 0;
        string day = "";
        switch (daysOfWeek)
        {
            case 0:
                day = "Sunday";
                break;
            case 1:
                day = "Monday";
                break;
            case 2:
                day = "Tuesday";
                break;
            case 3:
                day = "Wednesday";
                break;
            case 4:
                day = "Thursday";
                break;
            case 5:
                day = "Friday";
                break;
            case 6:
                day = "Saturday";
                break;
            default:
                day = "Invalid";
                break;
        }
    }
}
// this will not be allowed if you use file scoped namespace before
/*namespace RestaurantReviews
{
    namespace Reviews
    {

    }

}*/