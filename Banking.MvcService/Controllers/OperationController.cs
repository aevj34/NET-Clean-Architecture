using System.Collections.Generic;
using System.Web.Http;
using Banking.Application;
using Banking.Application.Dto;

namespace Banking.MvcService.Controllers
{
    public class OperationController : ApiController
    {
        //
        // GET: /Operation/{accountFrom}/{accountTo}/{mount}

        [HttpGet]
        public IEnumerable<string> Transfer(string accountFrom, string accountTo, decimal amount)
        {
            var bankingApplicationService = new BankingApplicationService();
            bankingApplicationService.PerformTransfer(new BankAccountDto { Number = accountFrom }, new BankAccountDto { Number = accountTo }, amount);
            return new[] { accountFrom, accountTo };
        }

    }
}
