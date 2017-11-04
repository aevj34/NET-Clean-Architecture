using Banking.Domain.Model;
using Banking.Domain.Repositories;
using Banking.Repository.Repositories.EntityFramework;
using System;
using System.Linq;

namespace Banking.Repository.Repositories
{
    public class BankAccountRepositoryEF : IBankAccountRepository
    {

        public BankAccount FindByNumber(string accountNumber)
        {

            var dbContext = new BankingEntities();

            var account = (from a in dbContext.Bank_account
                           where a.number.Equals(accountNumber)
                           select a).FirstOrDefault();

            var viewModel = new BankAccount();

            if (account == null) return viewModel;

            viewModel.Number = account.number;
            viewModel.Balance = account.balance;
            viewModel.IsLocked = account.locked;

            return viewModel;

        }

        public BankAccount FindByNumberLocked(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public void save(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public void update(BankAccount entity)
        {
            throw new NotImplementedException();
        }

        public void merge(BankAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
