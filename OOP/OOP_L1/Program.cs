using System;
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
            BankAccount account = new BankAccount();

            account.SetAccountType(0);
            account.SetAmount(1000000);

            BankAccount account1 = new BankAccount();

            account1.SetAccountType(0);
            account1.SetAmount(100);

            Console.WriteLine(account);
            Console.WriteLine(account1);

            Console.ReadLine();
        }
    }
}