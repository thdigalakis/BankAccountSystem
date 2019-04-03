using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class CreditAccount : BankAccount
    {
        private double interestRate = 0.3;
        private double fee = 0.15;
        private decimal creditLimit = 500;

        public CreditAccount()
        {
            TypeOfAccount = "Credit Account";
        }
       
        public override bool Withdraw(decimal WithdrawAmount)
        {
            bool result = false;
            WithdrawAmount += (WithdrawAmount * (decimal)fee);

            if (Balance >= WithdrawAmount && TransactionLimit >= WithdrawAmount)
            {
                Balance -= WithdrawAmount;
                Console.WriteLine("\nTransaction succeed.\n");
                result = true;
            }
            else
            {
                if (WithdrawAmount > creditLimit)
                    Console.WriteLine("\nYour credit limit is not sufficient for this transaction.");
                else
                    Console.WriteLine("\nYour transaction limit is: {0}. ", TransactionLimit);
            }
            return result;
        }

    }
}
