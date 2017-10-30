using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Exceptions
{

public class AmountLessOrEqualToZeroException : Exception
{
    public AmountLessOrEqualToZeroException() :
        base("The amount cannot be less than or equal to zero") {
    }
}
}
