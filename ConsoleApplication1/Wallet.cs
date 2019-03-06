using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Wallet
    {
        public List<Card> cards = new List<Card>();
        public double interest = 0; 

        public Wallet(Card c)
        {
            cards.Add(c);
        }

        public void addCard(Card c)
        {
            cards.Add(c); 
        }

        
    }
}
