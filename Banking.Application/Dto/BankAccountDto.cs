using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Dto
{
    public class BankAccountDto
    {
        private long id;
        private String number;
        private decimal balance;
        private bool isLocked;
        private CustomerDto customer;

        public long getId()
        {
            return id;
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public String getNumber()
        {
            return number;
        }

        public void setNumber(String number)
        {
            this.number = number;
        }

        public decimal getBalance()
        {
            return balance;
        }

        public void setBalance(decimal balance)
        {
            this.balance = balance;
        }

        public bool getIsLocked()
        {
            return isLocked;
        }

        public void setLocked(bool isLocked)
        {
            this.isLocked = isLocked;
        }

        public CustomerDto getCustomer()
        {
            return customer;
        }

        public void setCustomer(CustomerDto customer)
        {
            this.customer = customer;
        }
    }
}
