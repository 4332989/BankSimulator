using System;
using System.Collections.Generic;
/// <summary>
/// BankSimulator class
/// </summary>
namespace BankSimulator
{
    /// <summary>
    /// BankAccount class
    /// </summary>
    public abstract class BankAccount
    {
        /// <summary>
        /// declare private integer _accNumber
        /// </summary>
        private int _accNumber;
        /// <summary>
        /// declare private double _balance to 0
        /// </summary>
        private double _balance = 0;
        /// <summary>
        /// declare AccountType _type
        /// </summary>
        private AccountType _type;
        /// <summary>
        /// contructor for account number & type
        /// </summary>
        /// <param name="accNumber"></param>
        /// <param name="type"></param>
        public BankAccount(int accNumber, AccountType type)
        {
            _accNumber = accNumber;
            _type = type;
        }
        /// <summary>
        /// read _accNumber
        /// </summary>
        public int AccNumber
        {
            get
            {
                return _accNumber;
            }
        }
        /// <summary>
        /// read _balance
        /// </summary>
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        /// <summary>
        /// access Type
        /// </summary>
        public AccountType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// add amt to _balance
        /// </summary>
        /// <param name="amt"></param>
        public void Deposit(double amt)
        {
            _balance = Balance + amt;
        }
        /// <summary>
        /// minus amt to _balance
        /// </summary>
        /// <param name="amt"></param>
        public void Withdraw(double amt)
        {
            if (_balance >= amt)
                _balance = Balance - amt;
            else
                Console.WriteLine("Insufficient Balance! (Account: {0})", _accNumber);
        }
        /// <summary>
        /// return account details depending on account type
        /// </summary>
        /// <returns></returns>



        public abstract string Details();
                /*{
                    string de;
                    if (_type == AccountType.Current)
                    {
                        de = ("Current Account      :" + _accNumber + "     Balance:" + Balance);
                        return de;
                    }
                    else if (_type == AccountType.FixedDeposit)
                    {
                        de = ("Fixed Deposit Account:" + _accNumber + "     Balance:" + Balance);
                        return de;
                    }
                    else if (_type == AccountType.Saving)
                    {
                        de = ("Saving Account       :" + _accNumber + "     Balance:" + Balance);
                        return de;
                    }
                    else
                        return "";
                        */
    }
}
}

