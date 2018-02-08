using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
    public class Accounts
    {
        //fields
        private int accountNumber;
        private int balance;

        

        //prop
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public double Deposit { get; }
        private int Withdraw { get; set; }

        //construcotrs
        public Accounts()
        {
            //default constructor
        }

        public Accounts(int balance)
        {
            this.Balance = balance;
        }


        //methods
        public static void Clear()
        {

        }

        public virtual void SeeBalance()
        {
            this.Balance = balance;
        }

        public void GetAccountNumber(int accountNumber)
        {
            this.AccountNumber = accountNumber;
            Console.WriteLine(AccountNumber);
        }

    }
}
