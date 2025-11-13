using System.Collections.Immutable;
using static ConsoleApp1.Week3;
namespace ConsoleApp1
{
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

        }
    }
    }