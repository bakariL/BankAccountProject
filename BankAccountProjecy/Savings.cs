using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
    public class Savings : Accounts
    {

        //states

        //properties
        public int SavingsNumber { get; set; }
        public int SavingsBalance { get; set; }

        //contrustors
        public Savings()
        {
            //default constructors 
        }

        public Savings(int sBalance)
        {
            sBalance = 500;
            this.SavingsBalance = sBalance ;
        }

        //methods
        public void SeeSavingBalance()
        {
            int sBalance = 500;
            this.SavingsBalance = sBalance;
            Console.WriteLine("Savings balance: " + SavingsBalance);

        }

        public void DepositSavings(int depositSaving)
        {
            this.SavingsBalance += depositSaving;
            Console.WriteLine("Updated savings: " + SavingsBalance);
        }

        public void Withdrawal(int withdrawSaving)
        {
            if (this.SavingsBalance < 10)
            {
                Console.WriteLine("Not enough funds to withdraw");
                //exit???
            }
            else
            {

                this.SavingsBalance -= withdrawSaving;
                Console.WriteLine("Updated savings: " + SavingsBalance);
            }
        }


    }
}
