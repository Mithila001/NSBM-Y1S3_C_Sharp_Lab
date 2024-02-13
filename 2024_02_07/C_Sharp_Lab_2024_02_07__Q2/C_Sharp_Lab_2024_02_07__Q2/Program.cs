using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lab_2024_02_07__Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deposite();
        }

        public static void Deposite()
        {
            BanckAccount banckAccount = new BanckAccount();
            Console.Write("Enter you'r account number: ");
            string userInputAccount = Console.ReadLine();
            banckAccount.accountNumber += InputValidate(userInputAccount);
            Console.Write("Enter the deposite amount:");
            string userInputBalance = Console.ReadLine();
            banckAccount.accountBalance += InputValidate(userInputBalance);
            Console.WriteLine("Current account balance is: "+ banckAccount.accountBalance);

        }

        public static int InputValidate(string input)
        {
            int valideInput;
            if(int.TryParse(input, out valideInput))
            {
                return valideInput;
            }
            else
            {
                Console.WriteLine("Invalide Input!!");
                return 0;
            }
        }
    }

    public class BanckAccount
    {
        public int accountNumber;
        public int accountBalance;
    }
}
