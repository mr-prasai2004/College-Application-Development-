using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Week2
    {
        public class Tasks
        {
            public void RunTasks()
            {
                string userName = "Aayush";
                int luckyNumber = 7;
                Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

                Console.WriteLine($"Value of PI: {Circle.PI}");

                double radius = 5;
                Console.WriteLine($"Area of circle with radius {radius}: {Circle.CalculateArea(radius)}");
                Console.WriteLine($"Perimeter of circle with radius {radius}: {Circle.CalculatePerimeter(radius)}");

                byte userAge = 22;
                short studentCount = 32000;
                int userId = 123456;
                long population = 9876543210;

                float height = 5.9f;
                double weight = 72.56;
                decimal accountBalance = 1200.75m;

                char grade = 'A';
                bool isActive = true;

                string fullName = "Aayush Prasai";

                Guid uniqueId = Guid.NewGuid();
                DateTime currentDate = DateTime.Now;
                TimeSpan timeSinceMidnight = DateTime.Now - DateTime.Today;

                int number = 42;
                string numberString = number.ToString();
                string piString = "3.14";
                double convertedPi = Convert.ToDouble(piString);

                Console.WriteLine($"Byte: {userAge}");
                Console.WriteLine($"Short: {studentCount}");
                Console.WriteLine($"Int: {userId}");
                Console.WriteLine($"Long: {population}");
                Console.WriteLine($"Float: {height}");
                Console.WriteLine($"Double: {weight}");
                Console.WriteLine($"Decimal: {accountBalance}");
                Console.WriteLine($"Char: {grade}");
                Console.WriteLine($"Bool: {isActive}");
                Console.WriteLine($"String: {fullName}");
                Console.WriteLine($"Guid: {uniqueId}");
                Console.WriteLine($"DateTime: {currentDate}");
                Console.WriteLine($"TimeSpan: {timeSinceMidnight}");
                Console.WriteLine($"Converted Int to String: {numberString}");
                Console.WriteLine($"Converted String to Double: {convertedPi}");

                Console.WriteLine("\n--- Task 4: Arrays and Array Methods ---");

                int[] favoriteNumbers = { 9, 2, 7, 5, 1 };

                Console.WriteLine("Original Array:");
                foreach (int n in favoriteNumbers)
                    Console.Write(n + " ");

                Array.Sort(favoriteNumbers);
                Console.WriteLine("\nSorted (Ascending):");
                foreach (int n in favoriteNumbers)
                    Console.Write(n + " ");

                Array.Reverse(favoriteNumbers);
                Console.WriteLine("\nReversed (Descending):");
                foreach (int n in favoriteNumbers)
                    Console.Write(n + " ");

                int searchValue = 7;
                int index = Array.IndexOf(favoriteNumbers, searchValue);
                Console.WriteLine($"\nIndex of {searchValue}: {index}");

                Console.WriteLine("\n--- Task 5: DateTime and TimeSpan ---");

                DateTime birthDate = new DateTime(2003, 4, 5);
                DateTime now = DateTime.Now;
                TimeSpan difference = now - birthDate;

                int ageInYears = (int)(difference.TotalDays / 365.25);

                Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
                Console.WriteLine($"Current Date: {now.ToShortDateString()}");
                Console.WriteLine($"Age: {ageInYears} years");

                DateTime afterTenDays = birthDate.AddDays(10);
                Console.WriteLine($"10 Days after Birth Date: {afterTenDays.ToShortDateString()}");

                Console.WriteLine("\n--- Task 6: Generic Collections (List & Dictionary) ---");

                List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
                fruits.Add("Orange");
                fruits.Remove("Apple");

                Console.WriteLine("Fruits in List:");
                foreach (string fruit in fruits)
                    Console.WriteLine(fruit);

                Dictionary<int, string> fruitDict = new Dictionary<int, string>
                {
                    { 1, "Mango" },
                    { 2, "Banana" },
                    { 3, "Orange" }
                };
                fruitDict.Add(4, "Grapes");

                Console.WriteLine("\nFruit Dictionary:");
                foreach (var kvp in fruitDict)
                    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

                Console.WriteLine("\n--- End of Workshop ---");
            }
        }

        public class Circle
        {
            public const double PI = 3.14;
            public readonly double ReadonlyRadius;

            public Circle(double radius)
            {
                ReadonlyRadius = radius;
            }

            public static double CalculateArea(double radius)
            {
                return PI * radius * radius;
            }

            public static double CalculatePerimeter(double radius)
            {
                return 2 * PI * radius;
            }
        }
    }
}
