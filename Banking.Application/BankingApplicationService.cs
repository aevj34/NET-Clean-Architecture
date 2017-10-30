using Banking.Application.Dto;
using Banking.Domain.Model;
using Banking.Domain.Repositories;
using Banking.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application
{
    public class BankingApplicationService
    {
	private IBankAccountRepository bankAccountRepository;
	private TransferDomainService transferDomainService;

	public void performTransfer(BankAccountDto originBankAccountDto, BankAccountDto destinationBankAccountDto,
			decimal amount) 
    {
		BankAccount originAccount = this.bankAccountRepository.findByNumberLocked(originBankAccountDto.getNumber());
		BankAccount destinationAccount = this.bankAccountRepository.findByNumberLocked(destinationBankAccountDto.getNumber());
		this.transferDomainService.performTransfer(originAccount, destinationAccount, amount);
		this.bankAccountRepository.save(originAccount);
		this.bankAccountRepository.save(destinationAccount);
	}


    }
}
