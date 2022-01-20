using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L1
{

    public enum Accounttype : int
    {
        accountcurrent,
        settlement,
        credit,
        deposit
    }
    public class BankAccount
    {
        public decimal Amaunt
        {
            get
            {
                return _amount;
            }
        }

        public Accounttype Type 
        {
            get
            { 
                return _type; 
            } 
        }

        public void Withdraw(decimal sum)
        {
            if (_amount < sum) 
            {
                throw new Exception("Недостаточно средств на счете.");
            };

            _amount -= sum;
        }

        public void UpAccount(decimal sum)
        { 
            _amount += sum;
        }

        public int Number 
        {
            get 
            {
                return _number;
            }
        }
        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="amaunt"></param>
        public BankAccount(Accounttype type, decimal amaunt)
        {
            _type = type;
            _amount = amaunt;

            SetNumber();
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public BankAccount()
        {
            _type = Accounttype.accountcurrent;
            _amount = 0;

            SetNumber();
        }

        protected static int _nextNumber;
        /// <summary>
        /// Номер счета
        /// </summary>
        protected int _number;

        protected decimal _amount;
        /// <summary>
        /// Тип счета. Персечисление
        /// </summary>
        protected Accounttype _type;

        /// <summary>
        /// Установить номер счета
        /// </summary>
        /// <param name="newNumber"> номер счета int</param>
        protected void SetNumber()
        {
            _number = _nextNumber;
            _nextNumber += 1;
        }

        public override string ToString()
        {
            return $"N:{_number} T:{_type} Summ: {_amount}";
        }

    }
}
