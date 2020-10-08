using System;
using System.Collections.Generic;
using System.Text;

namespace DevAppsBank
{
    public class BankAccount
    {
        private readonly string _customerName;
        private decimal _balance;

        private BankAccount() { }

        /*public BankAccount(IDataServices dataServices, string customerName) 
        { 
            _customerName = customerName;
            _balance = dataServices.GetSalary(customerName);
        }*/

        public BankAccount(string customerName, decimal balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public void Debit(decimal amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance -= amount;
        }

        public void Credit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance += amount;
        }

    }
}

