using System;
using System.Linq;
using System.Text;

namespace OOP_L1
{
    internal class Program
    {

        static Program()
        {
            Console.WriteLine("ReverceLinq");
            Console.WriteLine(ReverceLinq("Hello world!"));
            Console.WriteLine("ReverceFor");
            Console.WriteLine(ReverceFor("Hello world!"));
        }

        static string ReverceFor(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        static string ReverceLinq(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(0, 10000000);

            BankAccount account1 = new BankAccount(Accounttype.credit, 200);

            Console.WriteLine($"На счетах : {account1.Amaunt + account.Amaunt}");

            Console.WriteLine(account);
            Console.WriteLine(account1);

            Console.WriteLine("Сняли со счета на карманные расходы.");
            account.Withdraw(1000000);

            Console.WriteLine($"На счетах : {account1.Amaunt + account.Amaunt}");

            Console.WriteLine(account);
            Console.WriteLine(account1);

            Console.WriteLine("Переместили со счета на счет.");

            account1.MoveFromAccount(account, 1000000);
            Console.WriteLine(account);
            Console.WriteLine(account1);

            Console.ReadLine();
        }
    }
}