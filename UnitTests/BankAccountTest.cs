using Banking.Domain.Model;
using Banking.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void findByNumber()
        {
            const String accountNumber = "123-456-002";

            BankAccountRepositoryAdoNet account = new BankAccountRepositoryAdoNet();
            var actual = account.FindByNumber(accountNumber);

            Assert.AreEqual(actual, actual);

        }

        [TestMethod]
        public void findByNumber2()
        {
            const string accountNumber = "123-456-002";

            var account = new BankAccountRepositoryAdoNet();
            var actual = account.FindByNumber2(accountNumber);

            Assert.AreEqual(actual, actual);

        }

        [TestMethod]
        public void findByNumberEF()
        {
            const String accountNumber = "123-456-002";

            BankAccountRepositoryEF account = new BankAccountRepositoryEF();
            var actual = account.FindByNumber(accountNumber);

            Assert.AreEqual(actual, actual);

        }


    }
}
