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

        /// <summary>
        /// Получить номер счета
        /// </summary>
        /// <returns>int номер счета</returns>
        public int GetNumber()
        {
            return _number;
        }


        /// <summary>
        /// ПолучитьТип счтеа
        /// </summary>
        /// <returns></returns>
        public Accounttype GetAccountType()
        {
           // if (_type == Accounttype.accountcurrent)
                return _type;
            //else
            //    return (Accounttype)0;
        }

        /// <summary>
        /// Получить сумму по счету
        /// </summary>
        /// <returns></returns>
        public decimal GetAmount()
        {
            return _amount;
        }

        public override string ToString()
        {
            return $"N:{_number} T:{_type} Summ: {_amount}";
        }

    }
}
