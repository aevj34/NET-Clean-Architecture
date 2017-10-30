using Banking.Domain.Model;
using Banking.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Repository.Test
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void findByNumber()
        {
            const String accountNumber="123-456-002";

            BankAccountRepositoryAdoNET account = new BankAccountRepositoryAdoNET();
            var actual = account.findByNumber(accountNumber);

            Assert.AreEqual(actual, actual);

        }
    }
}
