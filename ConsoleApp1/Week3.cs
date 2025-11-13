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


        //Task 3
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

        //Task4

        public class days { 
        public void printDay(int day)
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day");
                        break;
                }
                }




        }

        public class LoopEg
        {
            public void LoopEx()
            {
                Console.Write("Enter a number N: ");
                int N = int.Parse(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                }

                Console.WriteLine($"Sum from 1 to {N} is: {sum}");
            }
        }


        public class WhileLoop
        {
            public void WhileLoopEx()
            {
                int num = 1;
                while (num <= 20)
                {
                    if (num % 4 == 0)
                    {
                        num++;
                        continue; 
                    }

                    if (num == 15)
                        break; 

                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }
        }


    }
}


