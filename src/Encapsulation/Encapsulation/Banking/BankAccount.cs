using System;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber = string.Empty;
        private string _accountHolder = string.Empty;
        private double _balance;

        public string AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        }

        public string AccountHolder
        {
            get => _accountHolder;
            set => _accountHolder = string.IsNullOrWhiteSpace(value) ? "Unknown" : value;
        }

        public double Balance
        {
            get => _balance;
            private set => _balance = value < 0 ? 0 : value;
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && _balance - amount >= 0)
            {
                _balance -= amount;
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}