using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
    class Program
    {
        static void Main(string[] args)
        {

            Client info = new Client();
            //Accounts userAccount = new Accounts();
            CheckingAccount userChecking = new CheckingAccount();
            Savings userSavings = new Savings();

            Console.WriteLine("Welcome to Lewis Bank");
            Console.WriteLine("Please enter your first and last name");
            string userName = Console.ReadLine();

            int userPick;
            do
            {
                //1. View Clients Information 
                Console.WriteLine("1. View Client Information");


                // 2. View Account Balance
                Console.WriteLine("2. View Account Balance");

                //3. Deposit Funds
                Console.WriteLine("3. Deposit Funds");

                //4. Withdraw Funds
                Console.WriteLine("4. Withdraw Funds");
                //5. Exit
                Console.WriteLine("5. exit..");
                userPick = int.Parse(Console.ReadLine());

                if (userPick == 1)  ///pick 1 see acount 
                {
                    Console.Clear();
                    Console.WriteLine("users name " + userName);
                    userChecking.SeeBalance();
                    userSavings.SeeSavingBalance();
                    continue;


                }
                else if (userPick == 2) //picks 2 see balance
                {
                    Console.Clear(); //clears menu
                                     //type 1 checking for account
                                     //type 2 for savings account 
                    Console.WriteLine("1. Checking account");
                    Console.WriteLine("2. Savings account");
                    int userChoice = int.Parse(Console.ReadLine());
                    if (userChoice == 1)
                    {
                        Console.Clear();

                        //view checking balance
                        userChecking.SeeBalance();
                        //would you like to deposit? 
                        //3. Deposit Funds
                        Console.WriteLine("3. Deposit Funds");

                        //4. Withdraw Funds
                        Console.WriteLine("4. Withdraw Funds");

                        userChoice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (userChoice == 3)

                        {
                            //deopsit funds
                            Console.Clear();
                            Console.WriteLine("how much would you like to deposit");
                            int deposit = int.Parse(Console.ReadLine());
                            userChecking.DepsitChecking(deposit);
                            continue;
                        }
                        else if (userChoice == 4)
                        {
                            //withdraw funds
                            Console.Clear();
                            Console.WriteLine("How much would you like to withdraw?");
                            int withdraw = int.Parse(Console.ReadLine());
                            userChecking.WithdrawChecking(withdraw);
                            continue;
                        }


                    }
                    else if (userChoice == 2)
                    {
                        Console.Clear();

                        //view checking balance
                        userSavings.SeeSavingBalance();
                        //would you like to deposit? 
                        //3. Deposit Funds
                        Console.WriteLine("3. Deposit Funds");

                        //4. Withdraw Funds
                        Console.WriteLine("4. Withdraw Funds");

                        userChoice = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (userChoice == 3)

                        {
                            //deopsit funds
                            Console.Clear();
                            Console.WriteLine("how much would you like to deposit");
                            int deposit = int.Parse(Console.ReadLine());
                            userSavings.DepositSavings(deposit);
                            
                        }
                        else if (userChoice == 4)
                        {
                            //withdraw funds
                            Console.Clear();
                            Console.WriteLine("How much would you like to withdraw?");
                            int withdraw = int.Parse(Console.ReadLine());
                            userSavings.Withdrawal(withdraw);
                            continue;
                        }

                        else
                        {
                            Console.WriteLine("please eneter 1 or 2");
                        }
                        Console.WriteLine("What would you like to do?");
                    }

                }
                continue;
                } while (userPick != 5) ;
              
    
    } }}
