using System.Collections.Immutable;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1
            //string UserName = "Aayush";
            //int LuckyNumber= 7;
            //Console.WriteLine($"Hello { UserName}!Your Lucky Number is { LuckyNumber}");

            ////int pi = 5;
            ////Console.WriteLine(pi);


            //Task 3
            double pi = 3.14;
            byte age = 22;
            bool isMale = true;
            char grade = 'A';
            int nn = 12;
            short num = 123;
            long numm = 1234567898765;
            decimal nummm = 2.1312m;
            float haha = 1234f;
            string str = num.ToString();
            Console.WriteLine(str);
            string pii = "3.14";
            double piii= Convert.ToDouble(pii);
            Console.WriteLine(piii);

            int[] number = { 1, 8, 2, 4 };
            
            Array.Sort(number);
            Console.WriteLine("Arranging in Asc Order:");
            foreach (int j in number)
            {
                Console.WriteLine(j);
            }
            Array.Reverse(number);
            Console.WriteLine("The Reverse Num after sort is:");

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
            Array.Sort(number);

            foreach (int a in number)
            {
                Console.WriteLine(a);
            }







        }

        //Task2
        //static void circle()
        //{
        //    const double pi= 3.14;

        //}
    }
}
