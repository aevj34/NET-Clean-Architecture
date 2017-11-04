using System.Collections.Generic;

namespace Banking.Application.Dto
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BankAccountDto> BankAccountsDto { get; set; }

    }
}
