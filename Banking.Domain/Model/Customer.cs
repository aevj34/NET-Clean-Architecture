using System.Collections.Generic;

namespace Banking.Domain.Model
{
    public class Customer
    {
        public long Id;
        public string FirstName;
        public string LastName;
        public List<BankAccount> BankAccounts;

        public string FullName()
        {
            return string.Format("{0}, {1}", LastName, FirstName);
        }
    }
}
