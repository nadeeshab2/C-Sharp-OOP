﻿using System;

namespace BankAccountApplication
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive value.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposit of {amount:C} successful.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            BankAccount myAccount = new BankAccount(123456789, 100.00);


            double depositAmount = 50.00;
            myAccount.Deposit(depositAmount);


            Console.WriteLine($"Updated Balance: {myAccount.Balance:C}");


            Console.ReadKey();
        }
    }
}