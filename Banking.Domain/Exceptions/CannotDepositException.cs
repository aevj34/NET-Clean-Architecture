using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Exceptions
{
 public class CannotDepositException : Exception {
    public CannotDepositException():
        base("Cannot deposit in the account, it is locked"){
    }
}
}
