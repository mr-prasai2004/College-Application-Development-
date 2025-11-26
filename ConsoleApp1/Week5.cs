using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Week5
    {
       public class BankAccount
        {
            private string accountNumber;   // private fields  
            private double balance;

            // AccountNumber: get only (value set using constructor)
            public string AccountNumber
            {
                get { return accountNumber; }
            }

            // Balance: get only, private set, cannot be negative or zero
            public double Balance
            {
                get { return balance; }
                private set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Balance cannot be 0 or negative. Setting to minimum 1.");
                        balance = 1;
                    }
                    else
                    {
                        balance = value;
                    }
                }
            }

            // Constructor - value passed here
            public BankAccount(string accNum, double openingBalance)
            {
                accountNumber = accNum;
                Balance = openingBalance;
            }

            // Deposit Method
            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Deposit amount must be greater than 0.");
                    return;
                }

                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }

            // Withdraw Method
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Withdraw amount must be greater than 0.");
                    return;
                }

                if (amount > balance)
                {
                    Console.WriteLine("Insufficient balance!");
                    return;
                }

                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }


        //Week 5 task2 
        public class Vehicle
        {
            public string Brand { get; set; }
            public int Speed { get; set; }

            public void Start()
            {
                Console.WriteLine($"{Brand} is starting...");
            }

            public void Stop()
            {
                Console.WriteLine($"{Brand} is stopping...");
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
            }
        }

        // Derived class 1
        public class Car : Vehicle
        {
            public int Seats { get; set; }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
            }
        }

        // Derived class 2
        public class Motorcycle : Vehicle
        {
            public bool HasStorageBox { get; set; }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Storage Box: {HasStorageBox}");
            }
        }


        //Week 5 task 3
        public class Printer
        {
            // 1. Print(string message)
            public void Print(string message)
            {
                Console.WriteLine("Message: " + message);
            }

            // 2. Print(int number)
            public void Print(int number)
            {
                Console.WriteLine("Number: " + number);
            }

            // 3. Print(string message, int count)
            public void Print(string message, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {message}");
                }
            }
        }

    }
}
