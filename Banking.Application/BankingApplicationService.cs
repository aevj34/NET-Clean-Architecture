using Banking.Application.Dto;
using Banking.Domain.Repositories;
using Banking.Domain.Services;
using System.Transactions;

namespace Banking.Application
{
    public class BankingApplicationService
    {
        private IBankAccountRepository _bankAccountRepository;
        private TransferDomainService _transferDomainService;

        public void PerformTransfer(BankAccountDto originBankAccountDto, BankAccountDto destinationBankAccountDto,
                decimal amount)
        {
            var scope = new TransactionScope();

            using (scope)
            {
                var originAccount = _bankAccountRepository.FindByNumberLocked(originBankAccountDto.Number);
                var destinationAccount = _bankAccountRepository.FindByNumberLocked(destinationBankAccountDto.Number);
                _transferDomainService.PerformTransfer(originAccount, destinationAccount, amount);
                _bankAccountRepository.save(originAccount);
                _bankAccountRepository.save(destinationAccount);

                scope.Complete();

            }

        }


    }
}
