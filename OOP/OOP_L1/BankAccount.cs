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

        public BankAccount()
        {
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
        /// Установить тип счета
        /// </summary>
        /// <param name="type">Тип счета int</param>
        public void SetAccountType(int type)
        {
            _type = (Accounttype)type;
        }

        /// <summary>
        /// ПолучитьТип счтеа
        /// </summary>
        /// <returns></returns>
        public Accounttype GetAccountType()
        {
            if (_type == Accounttype.accountcurrent)
                return _type;
            else
                return (Accounttype)0;
        }

        /// <summary>
        /// Установить сууму на счету
        /// </summary>
        /// <param name="summ"></param>
        public void SetAmount(decimal summ)
        {

            _amount = summ;
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
