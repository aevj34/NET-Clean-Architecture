using Banking.Domain.Exceptions;
using Banking.Domain.Model;

namespace Banking.Domain.Services
{
public class TransferDomainService {
	public void PerformTransfer(BankAccount originAccount, BankAccount destinationAccount, decimal amount) {
		ValidateData(originAccount, destinationAccount, amount);
		originAccount.WithdrawMoney(amount);
		destinationAccount.DepositMoney(amount);
	}

	private static void ValidateData(BankAccount originAccount, BankAccount destinationAccount, decimal amount) {
		if (originAccount == null || destinationAccount == null) {
			throw new InvalidTransferBankAccountException();
		}
		if (originAccount.Number.Equals(destinationAccount.Number)) {
			throw new SameTransferBankAccountException();
		}
	}
}
}
