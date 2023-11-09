using System;

namespace HelloWorld
{
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
        public string PrintHello(string firstName, string lastName) //method declaration/definition
        {// method body starts here
            return $"Hello {firstName} {lastName}";
        }//method body ends here
    }
}
