using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Model
{
    public class Customer
    {
        private long id;
        private String firstName;
        private String lastName;
        private List<BankAccount> bankAccounts;

        public Customer()
        {
        }

        public String getFullName()
        {
            return String.Format("%s, %s", this.lastName, this.firstName);
        }

        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public List<BankAccount> getBankAccounts()
        {
            return bankAccounts;
        }

        public void setBankAccounts(List<BankAccount> bankAccounts)
        {
            this.bankAccounts = bankAccounts;
        }

    }
}
