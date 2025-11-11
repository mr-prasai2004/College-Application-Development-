using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Week3
    {

        public class Operators
        {
            public void Add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            public void Subtract(int a, int b)
            {
                Console.WriteLine(a - b);
            }

            public void Multiply(int a, int b)
            {
                Console.WriteLine(a * b);
            }

            public void Divide(int a, int b)
            {
                if (b != 0)
                    Console.WriteLine(a / b);
                else
                    Console.WriteLine("Cannot divide by zero!");
            }

            public void Oddevenfinder(int a)
            {
                string result = (a % 2 == 0) ? "Even Number" : "Odd Number";
                Console.WriteLine(result);
            }
        }

        // Task 2
        public class NullOperator
        {
            public class PerformNullCheck
            {
                string username = "Aayush";

                public void PerformNullChecks()
                {
                    string Result = (username != null) ? username : "Username is not available";
                    Console.WriteLine("Result: " + Result);


                    string Result1 = username ?? "Username is not available";
                    Console.WriteLine("Result1: " + Result1);


                    username ??= "DefaultUsername";
                    Console.WriteLine("Result3: " + username);
                }
            }
        }


        public class AgeValidator
        {
            public void ValidateAge(int age)
            {
                if (age > 0 && age < 13)
                {
                    Console.WriteLine("Child");
                }
                else if (age >= 13 && age < 19)
                {
                    Console.WriteLine("Teenage");
                }
                else
                {
                    Console.WriteLine("Adult");
                }
            }
        }

    }
}


