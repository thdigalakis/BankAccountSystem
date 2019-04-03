using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{

    class LotteryAccount : BankAccount
    {
        private double interestRate = 0.3;
        private double winpercentage = 0.15;

        public LotteryAccount()
        {
            TypeOfAccount = "Lottery Account";
        }

        public override bool Withdraw(decimal WithdrawAmount)
        {
            bool result = false;
            WithdrawAmount += (WithdrawAmount * (decimal)winpercentage);

            if (Balance >= WithdrawAmount && TransactionLimit >= WithdrawAmount)
            {
                Balance -= WithdrawAmount;
                Console.WriteLine("\nTransaction succeed.\n");
                result = true;
            }
            else
            {
                if (WithdrawAmount > Balance)
                    Console.WriteLine("Your balance is not sufficient for this transaction.");
                else
                    Console.WriteLine("Your transaction limit is: {0}", TransactionLimit);
            }
            return result;
        }

    }
}
