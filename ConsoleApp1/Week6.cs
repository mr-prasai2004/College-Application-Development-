using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Week6
    {
        private double length;
        private double breadth;

        public delegate double DiscountStrategy(double price);

        // Task 1
        public double length1
        {
            get => length;
            set => length = value;
        }

        public double breadth1
        {
            get => breadth;
            set => breadth = value;
        }

        public double perimeter(double length, double breadth) => 2 * (length + breadth);
        public double GetArea() => length * breadth;

        public string ShowDetails()
            => $"Length: {length}, Breadth: {breadth}, Area: {GetArea()}, Perimeter: {perimeter(length, breadth)}";

        // Task 2
        public delegate double calculator(double a, double b);

        public double add(double x, double y) => x + y;
        public double sub(double x, double y) => x - y;

        public double FestivalDiscount(double p) => p * 0.80;
        public double SeasonalDiscount(double p) => p * 0.90;
        public double NoDiscount(double p) => p;

        public double CalculateFinalPrice(double original, DiscountStrategy strategy)
            => strategy(original);

        // Task 3
        public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
                if (condition(n))
                    Console.WriteLine(n);
        }

        // Task 4
        public List<int> SquareNumbers(List<int> nums)
            => nums.Select(n => n * n).ToList();

        public List<Book> FilterPremiumBooks(List<Book> books)
            => books.Where(b => b.Price > 1000).ToList();

        public List<Student> SortStudents(List<Student> list)
            => list.OrderBy(s => s.Name).ToList();

        // Task 5
        public (int totalCashiers, double totalSales, double highest, double lowest, double average)
        CalculateSales(List<CashierSales> sales)
            =>
            (
                sales.Count,
                sales.Sum(x => x.Amount),
                sales.Max(x => x.Amount),
                sales.Min(x => x.Amount),
                sales.Average(x => x.Amount)
            );

        public (bool under18, bool allAbove16) CheckApplicants(List<Applicant> apps)
            =>
            (
                apps.Any(a => a.Age < 18),
                apps.All(a => a.Age > 16)
            );

        public (int first, int last, int firstAbove4Min, int? safeAbove10)
        SongDurationTask(List<int> durations)
            =>
            (
                durations.First(),
                durations.Last(),
                durations.First(d => d > 240),
                durations.FirstOrDefault(d => d > 600)
            );

        // Task 6
        public List<TourResult> ProcessTours(List<Tour> tours)
        {
            return tours
                .Where(t => t.Price > 10000 && t.DurationInDays > 4)
                .Select(t => new TourResult
                {
                    CustomerName = t.CustomerName,
                    Destination = t.Destination,
                    Category = t.IsInternational ? "International" : "Domestic",
                    Price = t.Price
                })
                .OrderBy(t => t.Category)
                .ThenBy(t => t.Price)
                .ToList();
        }
    }

    public class Book
    {
        public string Name { get; set; }  
        public double Price { get; set; }
    }

    public class Student { public string Name { get; set; } }

    public class CashierSales
    {
        public string Name { get; set; }
        public double Amount { get; set; }
    }

    public class Applicant
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }

    public class Tour
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDays { get; set; }
        public bool IsInternational { get; set; }
    }

    public class TourResult
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
