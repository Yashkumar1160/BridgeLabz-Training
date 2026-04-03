using class_library;
using class_library.class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ms_tests
{
    [TestClass]
    public class BankAccountTests
    {
        //BankAccount object
        BankAccount account;

        //runs before every test
        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        //deposit test
        [TestMethod]
        public void Deposit_Test()
        {
            account.Deposit(500);
            Assert.AreEqual(1500, account.GetBalance());
        }

        //withdraw test
        [TestMethod]
        public void Withdraw_Test()
        {
            account.Withdraw(300);
            Assert.AreEqual(700, account.GetBalance());
        }

        //get balance test
        [TestMethod]
        public void GetBalance_Test()
        {
            Assert.AreEqual(1000, account.GetBalance());
        }

        //withdraw with insufficient funds test
        [TestMethod]
        public void Withdraw_Insufficient_Funds_Test()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                account.Withdraw(2000);
            });
        }
    }
}
