using System.Collections.Immutable;
using static ConsoleApp1.Week3;
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

            Week3.AgeValidator age= new Week3.AgeValidator();
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

        }




    }
    }