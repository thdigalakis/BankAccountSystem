using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class BankAccount
    {
        public decimal Balance { get; set; } = 0;
        public decimal TransactionLimit { get; set; } = 500;
        public string TypeOfAccount { get; set; }


        public bool Deposit(decimal DepositAmount)
        {
            bool result = true;
            Balance += DepositAmount;
            Console.WriteLine("\nTransaction succeed.\n");
            return result;
        }

        public virtual bool Withdraw(decimal WithdrawAmount)
        {
            bool result = false;

            if (Balance >= WithdrawAmount && TransactionLimit >= WithdrawAmount)
            {
                Balance -= WithdrawAmount;
                result = true;
                Console.WriteLine("\nTransaction succeed.\n");
            }
            else
            {
                if (Balance  < WithdrawAmount)
                    Console.WriteLine("\nYour balance is not sufficient for this transaction.");
                else
                    Console.WriteLine("\nYour transaction limit is: {0}", TransactionLimit);
            }
            return result;
        }


        

        

        

    }
}
