using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrintInfo
    {

        public void PrintSingleCard(Card c)
        {
            string print = "Card Balance:" + c.balance.ToString("0.00");
            Console.WriteLine(print);
            print = "Card Type:" + c.type;
            Console.WriteLine(print);
            print = "Card Interest:" + c.interest.ToString("0.00");
            Console.WriteLine(print);
            return;
        }

        public void PrintTotalWallet(Wallet w)
        {
            for(int i = 0; i < w.cards.Count(); i++)
            {
                PrintSingleCard(w.cards[i]);
            }
            return; 
        }

        public void PrintSingleWallet(Wallet w)
        {
            string print = "Interest on Wallet:" + w.interest.ToString("0.00");
            Console.WriteLine(print);
            return; 
        }

        public void PrintPersonCards(Person p)
        {
            for (int i = 0; i < p.wallets.Count(); i++)
            {
                PrintTotalWallet(p.wallets[i]);
            }
            return;
        }

        public void PrintPersonWallets(Person p)
        {
            for(int i = 0; i < p.wallets.Count(); i++)
            {
                PrintSingleWallet(p.wallets[i]);
            }
            return; 

        }

        public void PrintPerson(Person p)
        {
            string print = "Person Interest:" + p.interest.ToString("0.00");
            Console.WriteLine(print);
            return; 
        }        

        
    }
}
