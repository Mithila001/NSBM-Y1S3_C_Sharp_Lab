using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("Select the bank account type.\n1.Saving Account \n2.Current Account");
                string input1 = Console.ReadLine();

                if (input1 == "1")
                {
                    Console.WriteLine("Saving Account  \n1.Deposit \n2.Withdrawl");
                    string input2 = Console.ReadLine();

                    if (input2 == "1")
                    {
                        BankAccount savingAccount = new SaviingAccount();
                        savingAccount.Deposit();
                        Console.WriteLine("Saving Account --> Diposite Completed!");
                    }
                    else
                    {
                        BankAccount savingAccount = new SaviingAccount();
                        savingAccount.withdrawl();
                        Console.WriteLine("Saving Account --> withdrawl Completed!");

                }
                }
                else
                {
                    Console.WriteLine("Current Account \n1.Deposit \n2.Withdrawl");
                    string input2 = Console.ReadLine();

                    if (input2 == "2")
                    {
                        BankAccount currentAccount = new CurrentAccount();
                        currentAccount.Deposit();
                        Console.WriteLine("Current Account --> Diposite Completed!");
                }
                    else
                    {
                        BankAccount currentAccount = new CurrentAccount();
                        currentAccount.withdrawl();
                        Console.WriteLine("Current Account --> withdrawl Completed!");
                }
                }
          Console.ReadLine();
        }
    }

    abstract class BankAccount
    {
        public abstract void Deposit();
        public abstract void withdrawl();
    }

    class SaviingAccount : BankAccount
    {
        public override void Deposit()
        {
            /*Console.WriteLine("S_Depsoti");*/
        }

        public override void withdrawl()
        {
            /*Console.WriteLine("S_Withdrawl");*/
        }
    }

    class CurrentAccount : BankAccount
    {
        public override void withdrawl()
        {
            /*Console.WriteLine("C_Depsoti");*/
        }

        public override void Deposit()
        {
            /*Console.WriteLine("C_Withdrawl");*/
        }
    }
}
