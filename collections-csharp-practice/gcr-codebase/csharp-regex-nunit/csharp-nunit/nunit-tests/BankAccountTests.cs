using class_library;
using class_library.class_library;
using NUnit.Framework;
using System;

namespace nunit_tests
{
    [TestFixture]
    public class BankAccountTests
    {
        //BankAccount object
        BankAccount account;

        //runs before every test
        [SetUp]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        //deposit test
        [Test]
        public void Deposit_Test()
        {
            account.Deposit(500);
            Assert.AreEqual(1500, account.GetBalance());
        }

        //withdraw test
        [Test]
        public void Withdraw_Test()
        {
            account.Withdraw(300);
            Assert.AreEqual(700, account.GetBalance());
        }

        //exception test for insufficient funds
        [Test]
        public void Withdraw_Insufficient_Funds_Test()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                account.Withdraw(2000);
            });
        }
    }
}
