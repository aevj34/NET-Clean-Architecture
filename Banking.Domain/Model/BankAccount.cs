using Banking.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain.Model
{
 public class BankAccount {
	private long id;
    private String number;
    private decimal balance;
    private bool isLocked;
    private Customer customer;

    public BankAccount() {
    }

    public void Lock() {
        if (!this.isLocked) {
            this.isLocked = true;
        }
    }

    public void UnLock() {
        if (this.isLocked) {
            this.isLocked = false;
        }
    }

    public bool hasIdentity() {
        return !this.number.Trim().Equals("");
    }

    public void withdrawMoney(decimal amount) {
        this.validateAmount(amount);
        if (!this.canBeWithdrawed(amount)) {
            throw new CannotWithdrawException();
        }
        this.balance = this.balance - amount;
    }

    public void depositMoney(decimal amount)  {
        this.validateAmount(amount);
        if (this.isLocked) {
            throw new CannotDepositException();
        }
        this.balance =  this.balance + amount;
    }

    private void validateAmount(decimal amount)  {
        if (Math.Sign(amount)<= 0) {
            throw new AmountLessOrEqualToZeroException();
        }
    }

    public bool canBeWithdrawed(decimal amount) {
        return !this.isLocked && (this.balance.CompareTo(amount) >= 0);
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getNumber() {
        return this.number;
    }

    public void setNumber(String number) {
        this.number = number;
    }

    public decimal getBalance() {
        return this.balance;
    }

    public void setBalance(decimal balance)
    {
        this.balance = balance;
    }

    public bool getIsLocked() {
        return isLocked;
    }

    public void setIsLocked(bool isLocked)
    {
        this.isLocked = isLocked;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }
}
}
