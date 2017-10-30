using Banking.Domain.Exceptions;
using Banking.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Services
{
public class TransferDomainService {
	public void performTransfer(BankAccount originAccount, BankAccount destinationAccount, decimal amount) {
		this.validateData(originAccount, destinationAccount, amount);
		originAccount.withdrawMoney(amount);
		destinationAccount.depositMoney(amount);
	}

	private void validateData(BankAccount originAccount, BankAccount destinationAccount, decimal amount) {
		if (originAccount == null || destinationAccount == null) {
			throw new InvalidTransferBankAccountException();
		}
		if (originAccount.getNumber().Equals(destinationAccount.getNumber())) {
			throw new SameTransferBankAccountException();
		}
	}
}
}
