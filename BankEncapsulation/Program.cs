using System;

//In the main method of your application, create a new instance of the BankAccount class.  Allow the user of the application to
//Deposit money and retrieve their balance through the console.

namespace BankEncapsulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            BankAccount tonyDurlap = new BankAccount();

            tonyDurlap.Deposit(4386.22);

            tonyDurlap.GetBalance();
        }
    }
}