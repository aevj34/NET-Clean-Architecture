namespace Banking.Application.Dto
{
    public class BankAccountDto
    {
        public long Id{ get; set; }
        public string Number { get; set; }
        public decimal Balance { get; set; }
        public bool IsLocked { get; set; }
        public CustomerDto Customer { get; set; }
    }
}
