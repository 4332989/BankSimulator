using System;
using BankSimulator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    [TestClass]
    public class Testcustomer
    {
        [TestMethod]
        public void TestIndexer()
        {
            Customer customer = new Customer("me", "1234");
            BankAccount[] accounts =
            {
                new BankAccount(111, BankSimulator.AccountType.Saving),
                new BankAccount(222, BankSimulator.AccountType.Current)
            };
            foreach (BankAccount a in accounts)
            {
                customer.AddAccounts(a);
            }
            Assert.AreEqual(111, customer[0].AccNumber);
            Assert.AreNotEqual(AccountType.Saving, customer[1].Type);
        }
        public void TestConstructor()
        {
            Customer customer = new Customer("me", "1234");
            BankAccount[] accounts =
            {
                new BankAccount(111, BankSimulator.AccountType.Saving),
                new BankAccount(222, BankSimulator.AccountType.Current)
            };
            foreach (BankAccount a in accounts)
            {
                customer.AddAccounts(a);
            }
            Assert.AreEqual(AccountType.Saving, customer[0].Type);
            Assert.AreEqual(111, customer[0].AccNumber);
        }
        [TestMethod]
        public void TestAddAccount()
        {
            Customer customer = new Customer("me", "1234");
            BankAccount[] accounts =
            {
                new BankAccount(111, BankSimulator.AccountType.Saving),
                new BankAccount(222, BankSimulator.AccountType.Current)
            };
            foreach (BankAccount a in accounts)
            {
                customer.AddAccounts(a);
            }
            Assert.AreEqual(2, customer.Accounts.Count);
            customer.AddAccounts(new BankAccount(333, BankSimulator.AccountType.FixedDeposit));
            Assert.AreEqual(3, customer.Accounts.Count);
        }
        [TestMethod]
        public void TestRemoveAccount()
        {
            Customer customer = new Customer("me", "1234");
            BankAccount[] accounts =
            {
                new BankAccount(111, BankSimulator.AccountType.Saving),
                new BankAccount(222, BankSimulator.AccountType.Current)
            };
            foreach (BankAccount a in accounts)
            {
                customer.AddAccounts(a);
            }
            Assert.AreEqual(2, customer.Accounts.Count);
            customer.RemoveAccounts(accounts[0]);
            Assert.AreEqual(1, customer.Accounts.Count);
        }
    }
}

