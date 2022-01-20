﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0, 10000000);

            BankAccount account1 = new BankAccount(Accounttype.credit, 200);

            Console.WriteLine($"На счетах : {account1.Amaunt + account.Amaunt}");

            Console.WriteLine(account);
            Console.WriteLine(account1);

            Console.WriteLine("Сняли со счета на карманные расходы.");
            account.Withdraw(10000000);

            Console.WriteLine($"На счетах : {account1.Amaunt + account.Amaunt}");

            Console.WriteLine(account);
            Console.WriteLine(account1);

            Console.ReadLine();
        }
    }
}