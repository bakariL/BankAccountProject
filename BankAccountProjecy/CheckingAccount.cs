using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
    public class CheckingAccount : Accounts
    {

        //feilds
        int checking = 1000;

        //properties
        public double CheckingBalance { get; set; }
        public int CheckingNumber { get; set; }

        //constructors
        public CheckingAccount()
        {
            //default constrcutors
        }

        public CheckingAccount(int checking)
        {
            this.Balance = checking;
        }

        //methods

        public override void SeeBalance()
        {
            this.Balance = checking;
            Console.WriteLine("current balance: " + Balance);
        }


        public void DepsitChecking(int deposit)
        {
            Balance += deposit;
            Console.WriteLine("updated balance: " + Balance);
        }

        public void WithdrawChecking(int amountWithdraw)
        {
            Balance += amountWithdraw;
            Balance -=  amountWithdraw;
            Console.WriteLine("updated balance: " + Balance);
        }



    }
}
