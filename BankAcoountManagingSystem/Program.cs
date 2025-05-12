using System;

namespace BankSystem
{
    class BankAccount
    {
        public string Number { get; protected set; }
        public decimal Balance { get; protected set; }
        public string Owner { get; protected set; }
      
        public BankAccount(string number, decimal balance, string owner)
        {
            if (string.IsNullOrWhiteSpace(Number))
                throw new ArgumentNullException("Incorect number");
            if (Balance < 0)
                throw new ArgumentNullException("Incorect balance");
            if (string.IsNullOrWhiteSpace(Owner))
                throw new ArgumentNullException("Incorect owner name");

            this.Number = number;
            this.Balance = balance;
            this.Owner = owner;
        }
        public void PutMoney(decimal ammount)
        {
            this.Balance += ammount;
        }
        public bool WithdrawMoney(decimal ammount)
        {
            if (this.Balance >= ammount)
            {
                this.Balance -= ammount;
                return true;
            }
            else return false;
        }


    };

    class DepositAccount : BankAccount
    {

        public DepositAccount(string number, decimal initialBalance, string owner)
            : base(number, initialBalance, owner)
        {
            if (initialBalance <= 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance), "Початковий баланс для депозитного рахунку має бути більше нуля.");

            Console.WriteLine($"DepositAccount {Number} created.");
        }
    };

    class CreditAccount : BankAccount
    {
        public CreditAccount(string number, decimal initialBalance, string owner)
            :base (number, initialBalance, owner)
        {
            if (initialBalance <= 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance), "Початковий баланс для депозитного рахунку має бути більше нуля.");

            Console.WriteLine($"CreditAccount {Number} created.");
        }
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string number, decimal initialBalance, string owner)
            : base(number, initialBalance, owner)
        {
            if (initialBalance <= 0)
                throw new ArgumentOutOfRangeException(nameof(initialBalance), "Початковий баланс для депозитного рахунку має бути більше нуля.");

            Console.WriteLine($"SavingsAccount {Number} created.");
        }
    }
}
