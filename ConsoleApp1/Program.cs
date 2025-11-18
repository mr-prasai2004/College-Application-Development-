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



        }
    }
    }