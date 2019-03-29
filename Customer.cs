using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankSimulator
{
    public class Customer
    {
        private string _name;
        private string _PIN;
        private List<BankAccount> _accounts;
        public Customer(string PIN, string Name)
        {
            _accounts = new List<BankAccount>();
            _name = Name;
            _PIN = PIN;
        }
        public BankAccount this[int i]
        {
            get
            {
                return _accounts[i];
            }
        }
        public List<BankAccount> Accounts
        {
            get
            {
                return _accounts;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string PIN
        {
            get
            {
                return _PIN;
            }
            set
            {
                _PIN = value;
            }
        }
        public void AddAccounts(BankAccount a)
        {
            _accounts.Add(a);
        }
        public void RemoveAccounts(BankAccount a)
        {
            _accounts.Remove(a);
        }
    }
}

