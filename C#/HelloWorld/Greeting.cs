using System;

namespace HelloWorld
{
    public static class ProgramStringExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    internal class Greeting
    {    //readonly float pi;
        /*public Program()
        {
            pi = 3.14f;
        }*/

        // Type member
        //program statment
        /*
         C# is case sensitive
         statements ends with semi-colon
         C# is type safe as well
         */
        public string PrintHello(string firstName, string lastName, int age=25, decimal wageRate=60.76M) //method declaration/definition
        {// method body starts here
            return $"Hello, {firstName} {lastName} is {age} years old and earns ${wageRate} per hour";
        }//method body ends here
        public string PrintHello(string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName}";
        }
        public string PrintHello(int age, string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName} is {age} years old";
        }
        public string PrintHello(decimal wageRate, string lastName, string firstName)
        {
            return $"Hello, {firstName} {lastName} earns ${wageRate} per hour";
        }
    }
}
