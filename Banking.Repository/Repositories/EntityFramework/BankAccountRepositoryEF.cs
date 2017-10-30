using Banking.Application.Dto;
using Banking.Domain.Model;
using Banking.Domain.Repositories;
using Banking.Repository.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Repository.Repositories
{
   public class BankAccountRepositoryEF: IBankAccountRepository
    {

        public BankAccount findByNumber(string accountNumber)
        {

         BankingEntities dbContext= new BankingEntities();

         Bank_account account = (from a in dbContext.Bank_account
                        where a.number.Equals(accountNumber)
                        select a).FirstOrDefault();

        BankAccount viewModel = new BankAccount();
        viewModel.setNumber(account.number);
        viewModel.setBalance(account.balance);
        viewModel.setIsLocked(account.locked);

        return viewModel;

        }

        public BankAccount findByNumberLocked(string accountNumber)
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
