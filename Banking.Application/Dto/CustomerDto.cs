using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application.Dto
{
    public class CustomerDto
    {
        private String firstName;
        private String lastName;
        private List<BankAccountDto> bankAccountsDto;

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public List<BankAccountDto> getBankAccountsDto()
        {
            return bankAccountsDto;
        }

        public void setBankAccountsDto(List<BankAccountDto> bankAccountsDto)
        {
            this.bankAccountsDto = bankAccountsDto;
        }
    }
}
