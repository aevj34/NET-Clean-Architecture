using Banking.Domain.Model;

namespace Banking.Domain.Repositories
{
    public interface IBankAccountRepository : IGenericRepository<BankAccount>
    {
        BankAccount FindByNumber(string accountNumber);
        BankAccount FindByNumberLocked(string accountNumber);
    }

}
