using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class CalculateInterest
    {
        private List<string> cardType = new List<string> { "VISA", "MASTER CARD", "DISCOVER" };
        private List<double> cardInterest = new List<double> { .1, .05, .01 };
        public double CalculateCardInterest(Card c)
        {
            try
            {
                int identifyCard = -1;
                for (int i = 0; i < cardType.Count(); i++)
                {
                    if (c.type.Equals(cardType[i]))
                    {
                        identifyCard = i;
                        break;
                    }
                }
                if(c.balance < 0)
                {
                    throw new SystemException("Balance is below 0 and should not be charged interest.");
                }
                if(identifyCard < 0)
                {
                    throw new SystemException("Card is of an invalid type");
                }

                c.interest = c.balance * cardInterest[identifyCard];
                return c.interest;
            }
            catch (SystemException e)
            {
                Console.WriteLine("Error in Calculate Card Interest! - " + e.Message, e);
                throw e;
            }
        }

        public double CalculateWalletInterest(Wallet w)
        {
            w.interest = 0;
            for (int i = 0; i < w.cards.Count(); i++)
            {
                w.interest += CalculateCardInterest(w.cards[i]);
            }
            return w.interest;
        }

        public void CalculatePersonInterest(Person p)
        {
            p.interest = 0;
            for (int i = 0; i < p.wallets.Count(); i++)
            {
                p.interest += CalculateWalletInterest(p.wallets[i]);
            }
            return;
        }

    }
}
