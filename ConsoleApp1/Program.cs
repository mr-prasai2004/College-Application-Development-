using System.Collections.Immutable;
using static ConsoleApp1.Week3;
using static ConsoleApp1.Week6;
namespace ConsoleApp1
{
    enum DayType { Weekend, Weekday }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Week2
            Week2.Tasks week2Tasks = new Week2.Tasks();
            week2Tasks.RunTasks();

            //Week3
            Week3.Operators operators = new Week3.Operators();
            operators.Add(10, 5);
            operators.Subtract(15, 8);
            operators.Multiply(4, 6);
            operators.Divide(20, 4);
            operators.Oddevenfinder(7);

            NullOperator.PerformNullCheck check = new NullOperator.PerformNullCheck();
            check.PerformNullChecks();

            Week3.AgeValidator age = new Week3.AgeValidator();
            age.ValidateAge(2);

            Week3.days days = new Week3.days();
            days.printDay(7);


            Week3.LoopEg LoopE = new Week3.LoopEg();
            LoopE.LoopEx();

            Week3.WhileLoop whileLoop = new Week3.WhileLoop();
            whileLoop.WhileLoopEx();

            Week3.ArrayEg arrayEg = new Week3.ArrayEg();
            arrayEg.ArrayEx();

            Week3.TryCatchEx tryCatch = new Week3.TryCatchEx();
            tryCatch.TryCatchEg();


            Week3.trycatcheg2 trycatcheg2 = new Week3.trycatcheg2();
            trycatcheg2.trycatchex2();



            //Week4


            Students student = new Students("Aayush Prasai", "SundarHaraincha-8 Morang", 21);
            student.displayInfo();


            // Task - 2
            Calculator cal = new Calculator();
            cal.PrintWelcomeMessage();
            double sum = cal.Add(5, 10);
            double product = cal.Multiplication(20, 60);
            Console.WriteLine($"Sum: {sum}, Product: {product}");


            // Task - 3
            ParameterDemo pd = new ParameterDemo();
            int number = 50;
            pd.Increase(ref number);
            pd.FullName(out string fullname);
            double total = pd.SumAll(10.5, 20.3, 30.2, 40.1);
            Console.WriteLine($"Increased Number: {number}, Full Name: {fullname}, Total Sum: {total}");


            // Task - 4
            Player player = new Player();
            Player player1 = new Player("Messi", "Advance", "Sound");
            Console.WriteLine($"Player1 - Name: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");


            // Task - 5
            Console.WriteLine("Enter the day name (Example: Sunday)");
            string datInput = Console.ReadLine();
            string d = datInput!.Trim().ToLower();
            DayType dayType;
            if (d == "friday" || d == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }
            Console.WriteLine($"{datInput} is a {dayType}.");

            //Week5
            // Create BankAccount object
            Week5.BankAccount acc = new Week5.BankAccount("ACC1001", 500);

            Console.WriteLine("Account Number: " + acc.AccountNumber);
            Console.WriteLine("Opening Balance: " + acc.Balance);

            acc.Deposit(200);
            acc.Withdraw(150);

            Console.WriteLine("Remaining Balance: " + acc.Balance);




            //Week 5 task 2:
            // Create Car object

            Console.WriteLine("Vehicle Information:");
            Week5.Car car = new Week5.Car();
            car.Brand = "Toyota";
            car.Speed = 180;
            car.Seats = 5;

            // Create Motorcycle object
            Week5.Motorcycle moto = new Week5.Motorcycle();
            moto.Brand = "Honda";
            moto.Speed = 120;
            moto.HasStorageBox = true;

            // Call base class methods
            car.Start();
            car.DisplayInfo();
            car.Stop();

            Console.WriteLine();

            moto.Start();
            moto.DisplayInfo();
            moto.Stop();

            Console.ReadLine();


            // -------- TASK 3 TEST ---------

            Week5.Printer printer = new Week5.Printer();

            // Call Print(string)
            printer.Print("Hello Polymorphism!");

            // Call Print(int)
            printer.Print(100);

            // Call Print(string, int)
            printer.Print("Repeated message", 3);


            Week5.NepaliTeacher nepaliT = new Week5.NepaliTeacher();
            nepaliT.Name = "Ram";
            Console.WriteLine("Nepali Teacher:");
            nepaliT.Teaching();   // overridden
            nepaliT.SalaryInfo(); // sealed method
            Console.WriteLine();

            // English Teacher object
            Week5.EnglishTeacher englishT = new Week5.EnglishTeacher();
            englishT.Name = "John";
            Console.WriteLine("English Teacher:");
            englishT.Teaching();    // uses base class method
            englishT.SalaryInfo();



            //Task 4
            Week5.AbsCar caar = new Week5.AbsCar();
            Week5.AbsBike bike = new Week5.AbsBike();

            Console.WriteLine("Car:");
            caar.Display();
            caar.StartEngine();
            caar.StopEngine();

            Console.WriteLine();

            Console.WriteLine("Bike:");
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();

            // Task 5: Electronics Store

            Week5.ElectronicsStore store = new Week5.ElectronicsStore();

            // Create Laptop and Smartphone objects
            Week5.Laptop laptop = new Week5.Laptop("Dell", 1200);
            Week5.Smartphone smartphone = new Week5.Smartphone("Samsung", 900);

            // Add them to the store
            store.AddDevice(laptop);
            store.AddDevice(smartphone);

            // Display info + call child methods (downcasting)
            store.ShowAllDeviceDetails();




            //Week6

            Week6 rectangle = new Week6();
            rectangle.length1 = 10.5;
            rectangle.breadth1 = 5.1;
            Console.WriteLine(rectangle.ShowDetails());

            //Week6 task2

            Week6 calculator1 = new Week6();
            calculator del1;
            del1 = calculator1.add;
            Console.WriteLine($"Addition: {del1(10, 20)}");
            del1 = calculator1.sub;
            Console.WriteLine($"Subtraction: {del1(30, 15)}");

            Console.WriteLine("Festival Discount: " +
             calculator1.CalculateFinalPrice(1000, calculator1.FestivalDiscount));

            Console.WriteLine("Seasonal Discount: " +
                calculator1.CalculateFinalPrice(1000, calculator1.SeasonalDiscount));

            Console.WriteLine("No Discount: " +
                calculator1.CalculateFinalPrice(1000, calculator1.NoDiscount));

            Console.WriteLine("Lambda 30% Discount: " +
                calculator1.CalculateFinalPrice(1000, p => p * 0.70));


            //Task 3

            int[] arr = { 2, 5, 12, 20, 7 };

            Console.WriteLine("Even Numbers:");
            calculator1.ProcessNumbers(arr, n => n % 2 == 0);

            Console.WriteLine("Greater than 10:");
            calculator1.ProcessNumbers(arr, n => n > 10);

            // Task 4

            Console.WriteLine("Squares:");
            var squares = calculator1.SquareNumbers(new List<int> { 1, 2, 3, 4, 5 });
            squares.ForEach(Console.WriteLine);

            Console.WriteLine("\nPremium Books:");
            var books = new List<Book>
            {
                new Book { Name = "Book A", Price = 500 },
                new Book { Name = "Book B", Price = 1500 }
            };
            calculator1.FilterPremiumBooks(books).ForEach(b => Console.WriteLine(b.Name));

            Console.WriteLine("\nSorted Students:");
            var students = new List<Student>
            {
                new Student { Name="Ram" },
                new Student { Name="Aayush" },
                new Student { Name="Bimal" }
            };
            calculator1.SortStudents(students).ForEach(s => Console.WriteLine(s.Name));

            // Task 5

            var sales = new List<CashierSales>
            {
                new CashierSales { Name="A", Amount=200 },
                new CashierSales { Name="B", Amount=350 },
                new CashierSales { Name="C", Amount=500 }
            };

            var saleResult = calculator1.CalculateSales(sales);
            Console.WriteLine($"Total Cashiers: {saleResult.totalCashiers}");
            Console.WriteLine($"Total Sales: {saleResult.totalSales}");
            Console.WriteLine($"Highest Sale: {saleResult.highest}");
            Console.WriteLine($"Lowest Sale: {saleResult.lowest}");
            Console.WriteLine($"Average Sale: {saleResult.average:F2}");

            var applicants = new List<Applicant>
            {
                new Applicant { FullName="Ram", Age=17 },
                new Applicant { FullName="Shyam", Age=20 },
                new Applicant { FullName="Gita", Age=22 }
            };

            var appCheck = calculator1.CheckApplicants(applicants);
            Console.WriteLine($"Any under 18? {appCheck.under18}");
            Console.WriteLine($"All above 16? {appCheck.allAbove16}");

            var durations = new List<int> { 180, 250, 300, 700 };
            var songInfo = calculator1.SongDurationTask(durations);

            Console.WriteLine($"First Duration: {songInfo.first}");
            Console.WriteLine($"Last Duration: {songInfo.last}");
            Console.WriteLine($"> 4 Minutes First: {songInfo.firstAbove4Min}");
            Console.WriteLine($"> 10 Minutes Safe Value: {songInfo.safeAbove10}");

            // Task6
            

            var tours = new List<Tour>
            {
                new Tour{ CustomerName="Aayush", Destination="Japan", Price=15000, DurationInDays=6, IsInternational=true },
                new Tour{ CustomerName="Krisha", Destination="Pokhara", Price=12000, DurationInDays=5, IsInternational=false },
                new Tour{ CustomerName="Roshan", Destination="Korea", Price=18000, DurationInDays=7, IsInternational=true }
            };

            var results = calculator1.ProcessTours(tours);

            Console.WriteLine("Filtered & Sorted Tours:");
            foreach (var t in results)
            {
                Console.WriteLine($"{t.CustomerName} | {t.Destination} | {t.Category} | Rs {t.Price}");
            }

            


        }

    }
    }