using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     
    public class Card
    {
        private List<string> cardType = new List<string> { "VISA", "MASTER CARD", "DISCOVER" };
        private List<double> cardInterest = new List<double> { .1, .05, .01 };
        public double balance { get; set; }
        public string type { get; set; }
        public double interest { get; set; }

        public Card(double b, string t, double i = 0)
        {
            this.balance = b;
            this.type = t;
            this.interest = i; 
        }

        public void edit(double b, string t, double i = 0)
        {
            this.balance = b;
            this.type = t;
            this.interest = i;
        }
    }
}
