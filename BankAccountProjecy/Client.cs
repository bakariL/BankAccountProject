using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProjecy
{
    public  class Client
    {
        //feilds
        //private string name;
        //private bool hasChecking;
        //private bool hasSavings;


        //properties 3
        public string Name { get; set; }
        public bool HasChecking { get; set; }
        public bool HasSaving { get; set; }

        //constructor 1 
        public Client()
        {
            //default consrtuctor 
        }
        //method 1

            public void GetName()
        {

        }

       public void ClientInfo()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
         
        }

            public void SeeAll(string name,bool hasChecking ,bool hasSavings)
        {
            Name = name;
            HasChecking = hasChecking;
            HasSaving = hasSavings;
        }
    }
}
