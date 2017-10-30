using Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Repositories
{
    public interface IBankAccountRepository : IGenericRepository<BankAccount>
    {
        BankAccount findByNumber(String accountNumber);
        BankAccount findByNumberLocked(String accountNumber);
    }

}
