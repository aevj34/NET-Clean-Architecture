using System;

namespace Banking.Domain.Exceptions
{

    public class AmountLessOrEqualToZeroException : Exception
    {
        public AmountLessOrEqualToZeroException()
            : base("The amount cannot be less than or equal to zero")
        {
        }
    }
}
