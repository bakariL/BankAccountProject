using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
    class Bank_practice_
    {
        //list of objsects
        //having a list of objects as a property is important.

        //feilds
        //invible
        //properties
         public List<Client> AllClients { get; set; }  //i want my bank to have aproperty where it contains all of my clients to be associated with my bank
        public List<CheckingAccount> CheckingAccounts { get; set; }//i want all the chekcing accounts to be asscoiteed the my bank
        public List<Savings> SavingAccounts { get; set; } //i want all the savings account asscoited with my bank

        //if i wanted to have a method 
        //this method returns a list of strings
        //inside the method created a new List called clientNam made a new empty list
        //for each
        public List<string> DisplayClientNames() //returns a list
        {
            List<string> clientNames = new List<string>();  //create a new emtpy list. 
            foreach(Client client in AllClients)     //for each Client object in my all clients list, take that CLients name and add it to the new clientName list. 
            {
                clientNames.Add(client.Name); //grabs Name from client class
            }
            return clientNames; //returned is a list of the clients name. 
        }


    }
}
