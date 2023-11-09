﻿using System;
using System.Text;

namespace HelloWorld
{
    internal class AnotherClass
    {
        public void Print()
        {
            WriteLine("Hello, please print this line");
        }
        public static void CheckedUnchecked()
        {
            long a;//declaration
            a = 35; // assigning value
            int c = int.MaxValue;
            unchecked
            {
                WriteLine(c + 2);
            }
            long x = 922337203685477580;// int is 4 bytes numeric type
            checked
            {
                int y = (int)x; // long is 8 byte numeric type, implicit type conversion
                WriteLine(y);// this will lead to overflow exception
            }
        }
        public static void AboutStrings()
        {         // STRINGS
            string a; // declarations
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
            WriteLine(a.Length);

            //string interpolation
            string s1 = "Neosoft - ";
            string s2 = "sdworx";

            s1 += s2; // s1 = s1 + s2
            WriteLine(s1); // new string is created for s1 because strings are immutable

            StringBuilder sb = new StringBuilder("Neosoft - ");
            sb.Append("sdworx");

            WriteLine(sb.ToString());// String Build offers better performance as it creates a string buffer and manipulations are performed on the strings. 
            string firstName = "Pushpinder", lastName = "Kaur", Country = "England";
            WriteLine("The instructor name is {0} {1} and she is from {2}", firstName, lastName, Country);// composite formatting using String.Format
            WriteLine($"The instructor name is {firstName} {lastName} and she is from {Country}"); // uses string interpolation

        }

        public static void AboutConversionAndImplicitTypes()
        {
            string a = "10";
            int m = Int32.Parse(a);
            int n = Convert.ToInt32(a);
            WriteLine(n.GetType());
            var name = 25.00;//implicitly typed local variable
            WriteLine(name.GetType());
        }
        public static void AboutSelectStatements()
        {
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

        public void AboutDoWhile(int n)
        {
            do
            {
                Console.WriteLine(n);
                n++;//increment postfix operator => n=n+1
            } while (n < 0);
        }
        public void AboutWhile(int n)
        {
            while (n < 10)
            {
                Console.WriteLine(n);
                n++;//increment postfix operator => n=n+1
            }
        }

        public void AboutFor(int n)
        {
            for (int i = n; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void About1DArrays()
        {
            int[] scores = { 60, 98, 78, 100, 99 };//declare, initialize and assign values to array in 1 step
            Console.WriteLine($"Number of elements - {scores.Length}");
            /*for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"{scores[i]} ");
            }*/

            foreach (int i in scores)
            {
                Console.Write($"{i} ");
            }
        }

        public void About2DArrays()
        {
            int rows = 3;
            int columns = 2;
            int[,] matrix = new int[rows, columns];//declare and initialize 2D array
            matrix[0, 0] = 5;
            matrix[0, 1] = 7;
            matrix[1, 0] = 4;
            matrix[1, 1] = 9;
            matrix[2, 0] = 11;
            matrix[2, 1] = 10;

            Console.WriteLine($"Elements in the matrix - {matrix.Length}");
            Console.WriteLine($"Dimension of the matrix - {matrix.Rank}");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArrays()
        {
            //int[,,] Array3D = new int[3, 3, 4];
            int rows = 3;
            string[][] jaggedFamilies = new string[rows][];

            jaggedFamilies[0] = new string[2] { "Pushpinder-ArrowFunctions", "Kartar-ArrowFunctions" };
            jaggedFamilies[1] = new string[4] { "Astri-SDWorx", "Pravind-SDWorkx", "Mehtaab-SDWorx", "Ronnita-SDWorx" };
            jaggedFamilies[2] = new string[3] { "Joe-NeoSoft", "Gauresh-Neosoft", "Sneha-NeoSoft" };

            Console.WriteLine($"Length of Jagged Array - {jaggedFamilies.Length}");
            Console.WriteLine($"Rank of Jagged Array - {jaggedFamilies.Rank}");

            foreach (var row in jaggedFamilies)
            {
                foreach (var item in row)
                {
                    Console.Write($"{item} | ");
                }
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// Method that reverses a string without in build methods of C#
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string ReverseString(string str)// abscde => edcba
        {
            return "";
        }
    }
}
