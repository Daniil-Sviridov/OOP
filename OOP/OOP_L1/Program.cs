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
            account.SetNumber(550);
            account.SetAmount(1000000);

            Console.WriteLine(account);
            Console.ReadLine();
        }
    }
}