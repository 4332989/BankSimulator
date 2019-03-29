using System;
using BankSimulator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    /// <summary>
    /// unit testing BankSimulator
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Test Constructor
        /// </summary>
        [TestMethod]
        public void TestConstructor()
        {
            BankAccount bankacc = new BankAccount(111, BankSimulator.AccountType.Saving);
            Assert.AreEqual(AccountType.Saving, bankacc.Type);
            Assert.AreEqual(111, bankacc.AccNumber);
            Assert.AreEqual(0, bankacc.Balance);
        }
        /// <summary>
        ///  Test ChangeType
        /// </summary>
        [TestMethod]
        public void TestChangeType()
        {
            BankAccount bankacc = new BankAccount(111, BankSimulator.AccountType.Saving);
            Assert.AreEqual(AccountType.Saving, bankacc.Type);
            bankacc.Type = AccountType.FixedDeposit;
            Assert.AreNotEqual(AccountType.Saving, bankacc.Type);
        }
        /// <summary>
        /// Test Deposit
        /// </summary>
        [TestMethod]
        public void TestDeposit()
        {
            BankAccount bankacc = new BankAccount(111, BankSimulator.AccountType.Saving);
            Assert.AreEqual(0, bankacc.Balance);
            bankacc.Deposit(100);
            Assert.AreEqual(100, bankacc.Balance);
        }
        /// <summary>
        /// Test Withdraw
        /// </summary>
        [TestMethod]
        public void TestWithdraw()
        {
            BankAccount bankacc = new BankAccount(111, BankSimulator.AccountType.Saving);
            Assert.AreEqual(0, bankacc.Balance);
            bankacc.Deposit(100);
            bankacc.Withdraw(150);
            Assert.AreNotEqual(-50, bankacc.Balance);
            Assert.AreEqual(100, bankacc.Balance);
        }
        /// <summary>
        /// Test Withdraw With Zero
        /// </summary>
        [TestMethod]
        public void TestWithdrawWithZero()
        {
            BankAccount bankacc = new BankAccount(111, BankSimulator.AccountType.Saving);
            Assert.AreEqual(0, bankacc.Balance);
            bankacc.Withdraw(150);
            Assert.AreNotEqual(-150, bankacc.Balance);
            Assert.AreEqual(0, bankacc.Balance);
        }
        /// <summary>
        /// Test Details
        /// </summary>
        [TestMethod]
        public void TestDetails()
        {
            BankAccount bankacc = new BankAccount(111, BankSimulator.AccountType.Saving);
            bankacc.Deposit(100);
            bankacc.Withdraw(50);
            Assert.AreEqual("Saving Account       :111     Balance:50", bankacc.Details());
        }
    }
}

