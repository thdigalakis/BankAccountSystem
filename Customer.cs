using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Iban { get; set; } = "XXXXXX";
        public BankAccount Ba { get; set; } = null;


        public Customer() { }

        
        public Customer(string firstName, string lastName, string iban)
        {
            FirstName = firstName;
            LastName = lastName;
            Iban = iban;
        }

        public void PrintStatement(string reason, decimal amount)
        {
            string samount = (amount == 0) ? "  " : amount.ToString();
            Console.WriteLine($"IBAN XXXXXX\n" +
                              $"Name: {FirstName} {LastName}\n" +
                              $"Type: {Ba.TypeOfAccount}\n" +
                              $" DATE     |   REASON   |  AMOUNT | BALANCE\n" +
                              $"----------|------------|---------|---------\n" +
                              $"{DateTime.Today.ToString("dd-MM-yyyy")}    {reason}     {samount}      {Ba.Balance}"
                              );
        }
    }
}
