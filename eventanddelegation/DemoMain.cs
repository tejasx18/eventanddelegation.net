using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventanddelegation
{
    //If amount is greater than balance raise an event → insufficient balance
    //If balance is low (< 3000) raise an event low balance
    //If balance is zero then raise an event zero balance.

    public class DemoMain
    {
        public delegate void ShowMessage(int amount);
        public delegate void Disp();
        static void InsufficientBalance(int amount) {
            Console.WriteLine($"Insufficient Account Balance,current balance ={amount}, can not procede with transaction");
        }
        static void LowBalance(int amount)
        {
            Console.WriteLine($"Account Balance is less than 3000 , current account balance ={amount}");
        }
        static void ZeroBalance()
        {
            Console.WriteLine($"Account Balance is zero");
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Insufficient += new ShowMessage(InsufficientBalance);
            bank.LowBalance += new ShowMessage(LowBalance);
            bank.Zero += new Disp(ZeroBalance);

            bank.Debit(2500);
            bank.Debit(2500);
            bank.Credit(100);
            bank.Debit(200);
        }
    }
}
