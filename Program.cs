using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class Program
    {

        public static Customer CreateAccount()
        {
            int choice;
            string fName, lName, ib;
            Customer c = null;

            Console.WriteLine($"Welcome to Bank Account System\n" +
                              $"Please create an of the following accounts: \n");

            do
            {
                Console.WriteLine($"1. Saving Account\n" +
                                  $"2. Credit Account\n" +
                                  $"3. Lottery Account\n");
                choice = Int32.Parse(Console.ReadLine());
            } while (choice < 1 || choice > 3);

            Console.Clear();

            Console.WriteLine($"Please enter your name: ");
            fName = Console.ReadLine();

            Console.WriteLine($"Please enter your lastname: ");
            lName = Console.ReadLine();

            Console.WriteLine($"Please enter your Iban: ");
            ib = Console.ReadLine();

            Console.Clear();

            c = new Customer(fName, lName, ib);

            if (choice == 1)
            {
                c.Ba = new SavingsAccount();
            }
            else if (choice == 2)
            {
                c.Ba = new CreditAccount();
            }
            else
            {
                c.Ba = new LotteryAccount();
            }

            return c;
        }

        //--------------------------------------------------------------

        public static decimal getAmount()
        {
            decimal amount;
            do
            {
                Console.WriteLine("Pleace enter amount: \n");
                amount = Int32.Parse(Console.ReadLine());

            } while (amount <= 0);
            return amount;
        }



            static void Main(string[] args)
        {

            Customer c = null;
            int choice;
            decimal amount = 0;
            string reason = "        "; 


            c = CreateAccount();
            do
            {
                do
                {
                    Console.WriteLine($"\nPlease choose one of the following actions:  \n" +
                                      $"1. Withdraw\n" +
                                      $"2. Deposit\n" +
                                      $"3. Print Statement\n" +
                                      $"4. Quit\n\n");
                    choice = Int32.Parse(Console.ReadLine());
                } while (choice > 4 || choice < 1);

                Console.Clear();

                if (choice == 1)
                {
                    if (c.Ba.Withdraw(amount = getAmount())){
                        reason = "WITHDRAW";
                    }
                    else
                    {
                        amount = 0;
                    }
                }
                else if (choice == 2)
                {
                    if (c.Ba.Deposit(amount = getAmount()))
                    {
                        reason = "DEPOSIT";
                    }
                    else
                    {
                        amount = 0;
                    }
                }
                else if (choice == 3)
                {
                    c.PrintStatement(reason, amount);
                }
            } while (choice != 4);

            Console.WriteLine("Thank you for your preference!!!");
        }
    }
}
