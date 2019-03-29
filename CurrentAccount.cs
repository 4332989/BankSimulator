using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulator
{
    public class CurrentAccount:BankAccount
    {
        private double _limit;

        public CurrentAccount(int accnumber):base(accnumber,AccountType.Current)
        {
            _limit = -100000;
           
        }
        public override string Details()
        {

            string de;
            if (Balance<=_limit)
                de = ("error");
            else
            de = ("Current Account      :" + AccNumber + "     Balance:" + Balance+ "     Limit:"+_limit);
                return de;
            
        }
    }
}
