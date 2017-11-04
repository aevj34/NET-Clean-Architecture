using Banking.Domain.Exceptions;
using System;

namespace Banking.Domain.Model
{
    public class BankAccount
    {
        public long Id;
        public string Number;
        public decimal Balance;
        public bool IsLocked;
        public Customer Customer;

        public void Lock()
        {
            if (!IsLocked)
            {
                IsLocked = true;
            }
        }

        public void UnLock()
        {
            if (IsLocked)
            {
                IsLocked = false;
            }
        }

        public bool HasIdentity()
        {
            return !string.IsNullOrEmpty(Number);
        }

        public void WithdrawMoney(decimal amount)
        {
            ValidateAmount(amount);
            if (!CanBeWithdrawed(amount)) throw new CannotWithdrawException();

            Balance = Balance - amount;
        }

        public void DepositMoney(decimal amount)
        {
            ValidateAmount(amount);
            if (IsLocked) throw new CannotDepositException();
            
            Balance = Balance + amount;
        }        

        private static void ValidateAmount(decimal amount)
        {
            if (Math.Sign(value: amount) <= 0) throw new AmountLessOrEqualToZeroException();
        }

        public bool CanBeWithdrawed(decimal amount)
        {
            return !IsLocked && (Balance.CompareTo(amount) >= 0);
        }

       
    }
}
