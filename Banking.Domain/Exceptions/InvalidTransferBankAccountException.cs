using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Exceptions
{
public class InvalidTransferBankAccountException : Exception {
    public InvalidTransferBankAccountException():
        base("Cannot perform the transfer, invalid data in bank accounts specifications"){
    }
}
}
