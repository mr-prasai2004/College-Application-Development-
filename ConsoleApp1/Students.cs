using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Students
    {
        public string name = null!;
        public string address = null!;
        public int age;
        static string course;

        public Students(string name, string address, int age)
        {
            this.name = name;
            this.address = address;
            this.age = age;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Name: {name}, Address: {address}, Age: {age}");
        }
    }

    // Calculator class
    internal class Calculator
    {
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calulator app :)");
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Multiplication(double a, double b = 10)
        {
            return a * b;
        }
    }

    // ParameterDemo class
    internal class ParameterDemo
    {
        // ref passes the actual parameter not the copy so it changes the orignal value
        public void Increase(ref int number)
        {
            number = number + 10;
        }

        public void FullName(out string fullname)
        {
            fullname = "Aayush Prasai";
        }

        public double SumAll(params double[] numbers)
        {
            double result = 0;
            foreach (var num in numbers)
            {
                result += num;
            }
            return result;
        }
    }

    // Player class
    internal class Player
    {
        public string playerName = null!;
        public string level = null!;
        public string health = null!;

        public Player()
        {
            Console.WriteLine("Default Constructor called");
        }

        public Player(string playerName, string level, string health)
        {
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }
    }
}
