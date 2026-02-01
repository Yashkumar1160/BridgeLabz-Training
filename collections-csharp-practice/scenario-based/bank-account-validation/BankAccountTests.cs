using System;
using NUnit.Framework;
using BankAccountApp;

namespace BankAccountTests
{
    //test class attribute
    [TestFixture]
    internal class UnitTest
    {
        //test deposit with valid amount
        [Test]
        public void Test_Deposit_ValidAmount()
        {
            //create account with initial balance
            Program account = new Program(1000);

            //deposit amount
            account.Deposit(500);

            //verify updated balance
            Assert.AreEqual(1500, account.Balance);
        }

        //test deposit with negative amount
        [Test]
        public void Test_Deposit_NegativeAmount()
        {
            //create account with initial balance
            Program account = new Program(1000);

            //verify exception message
            Assert.AreEqual(
                "Deposit amount cannot be negative",
                Assert.Throws<Exception>(() => account.Deposit(-200)).Message
            );
        }

        //test withdraw with valid amount
        [Test]
        public void Test_Withdraw_ValidAmount()
        {
            //create account with initial balance
            Program account = new Program(1000);

            //withdraw amount
            account.Withdraw(400);

            //verify updated balance
            Assert.AreEqual(600, account.Balance);
        }

        //test withdraw with insufficient funds
        [Test]
        public void Test_Withdraw_InsufficientFunds()
        {
            //create account with initial balance
            Program account = new Program(500);

            //verify exception message
            Assert.AreEqual(
                "Insufficient funds.",
                Assert.Throws<Exception>(() => account.Withdraw(800)).Message
            );
        }
    }
}
