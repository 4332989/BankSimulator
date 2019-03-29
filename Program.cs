using System;
namespace BankSimulator
{
    class MainClass
    {
        /// <summary>
        /// main function
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            BankAccount[] bankacc = new BankAccount[4];
            bankacc[0] = new BankAccount(111, BankSimulator.AccountType.Saving);
            bankacc[1] = new BankAccount(222, BankSimulator.AccountType.Current);
            bankacc[2] = new BankAccount(333, BankSimulator.AccountType.FixedDeposit);
            bankacc[3] = new BankAccount(444, BankSimulator.AccountType.Saving);
            ShowAll(bankacc);
            Console.ReadKey();
            Console.Clear();
            bankacc[0].Deposit(100);
            bankacc[1].Withdraw(100);
            bankacc[2].Deposit(1000);
            bankacc[3].Deposit(500);
            bankacc[3].Withdraw(200);
            ShowAll(bankacc);
            Console.ReadKey();
        }
        /// <summary>
        /// call showall to get account details and print them
        /// </summary>
        /// <param name="bankacc"></param>
        private static void ShowAll(BankAccount[] bankacc)
        {
            foreach (BankAccount i in bankacc)
            {
                Console.WriteLine(i.Details());
            }
        }
    }
}

