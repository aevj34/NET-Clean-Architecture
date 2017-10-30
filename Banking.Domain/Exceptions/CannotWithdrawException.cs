using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Exceptions
{
 public class CannotWithdrawException : Exception {
    public CannotWithdrawException():
        base("Cannot withdraw in the account, it is locked or amount is greater than balance"){
    }
}
}
