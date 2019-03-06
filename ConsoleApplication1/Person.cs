using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        public List<Wallet> wallets = new List<Wallet>();
        public double interest = 0; 

        public Person(Wallet w)
        {
            wallets.Add(w);
        }

        public void addWallet(Wallet w)
        {
            wallets.Add(w);
        }
    }
}
