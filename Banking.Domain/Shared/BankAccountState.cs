using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Shared
{
    public class BankAccountState
    {
        public enum enumBankAccountState
        {
            ACTIVE, CLOSED, FROZEN, LOCKED, OVERDRWAN
        }

        private int id;
        private BankAccountState(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

    }
}
