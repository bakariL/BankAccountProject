using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
     public abstract class Accounts
    {
        //fields
        //private int accountNumber;
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


        //methods
        public static void Clear()
        {

        }

        public virtual void SeeBalance()
        {
            this.Balance = balance;
        }

        //public void GetAccountNumber(int accountNumber)
        //{
        //    this.AccountNumber = accountNumber;
        //    Console.WriteLine(AccountNumber);
        //}

    }
}
