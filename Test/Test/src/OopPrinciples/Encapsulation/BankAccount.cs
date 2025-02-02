using System;

namespace Test.OopPrinciples.Encapsulation
{
    public class BankAccount
    {
       private decimal balance;

       public BankAccount(decimal balance)
       {
            Deposit(balance);
       }

       public void Deposit(decimal amount)
       {
           if(amount <= 0)
           {
               throw new ArgumentException("Amount must be positive");
           }

           this.balance += amount;
       }

        public decimal GetBalance(){
            return this.balance;
        }

        /// <summary>
        /// Withdraw amount should be grater than 0 and less than the balance
        /// </summary>
        /// <param name="amount"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
       public void Withdraw(decimal amount)
       {
           if(amount <= 0)
           {
               throw new ArgumentException("Amount must be positive");
           }

           if(amount > this.balance)
           {
               throw new InvalidOperationException("Insufficient funds");
           }

           this.balance -= amount;
       }
    }
}