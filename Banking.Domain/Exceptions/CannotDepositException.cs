using System;

namespace Banking.Domain.Exceptions
{
    public class CannotDepositException : Exception
    {
        public CannotDepositException() :
            base("Cannot deposit in the account, it is locked")
        {
        }
    }
}
