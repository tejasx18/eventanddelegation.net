using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static eventanddelegation.DemoMain;

namespace eventanddelegation
{
    public class Bank
    {
        public event ShowMessage Insufficient;
        public event ShowMessage LowBalance;
        public event Disp Zero;
        private int balance;

        public Bank() {
            balance = 5000;
        }

        public Bank(int balance)
        {
            this.balance = balance;
        }

        public void Credit(int amount) { 
            balance += amount;
        }

        public void Debit(int amount) {
            if (balance < amount) {
                Insufficient(balance);
            }
            else
            {   balance -= amount;
                if (balance == 0)
                {
                    Zero();
                }
                else if (balance < 3000)
                {
                    LowBalance(balance);
                }
            }
        }
    }
}
