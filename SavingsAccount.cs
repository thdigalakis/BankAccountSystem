using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class SavingsAccount : BankAccount
    {
        private double interestRate = 0.2;
        public decimal withdraw { get; set; }
        public decimal deposit { get; set; }


        public SavingsAccount()
        {
            TypeOfAccount = "Saving Account";
        }


        public void AddInterest()
        {
            Balance = Balance + Balance * (decimal)interestRate; 
        }
    }
}
