using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test One
            CalculateInterest interest = new CalculateInterest();
            PrintInfo printInfo = new PrintInfo(); 

            Card card1 = new Card(100, "VISA");
            Card card2 = new Card(100, "MASTER CARD");
            Card card3 = new Card(100, "DISCOVER");

            Wallet wallet1 = new Wallet(card1);
            wallet1.addCard(card2);
            wallet1.addCard(card3);

            Person person1 = new Person(wallet1);

            interest.CalculatePersonInterest(person1);

            Console.WriteLine("-------------TEST 1-------------");
            printInfo.PrintPerson(person1);
            printInfo.PrintPersonCards(person1);


            //Test Two 
            Card card4 = new Card(100, "VISA");
            Card card5 = new Card(100, "DISCOVER");
            Card card6 = new Card(100, "MASTER CARD");

            Wallet wallet2 = new Wallet(card4);
            wallet2.addCard(card5);
            Wallet wallet3 = new Wallet(card6);

            Person person2 = new Person(wallet2);
            person2.addWallet(wallet3);

            interest.CalculatePersonInterest(person2);

            Console.WriteLine("-------------TEST 2-------------");
            printInfo.PrintPerson(person2);
            printInfo.PrintPersonWallets(person2);


            //Test Three
            Card card7 = new Card(100, "VISA");
            Card card8 = new Card(100, "MASTER CARD");
            Card card9 = new Card(100, "VISA");
            Card card10 = new Card(100, "MASTER CARD");

            Wallet wallet4 = new Wallet(card7);
            wallet4.addCard(card8);
            Wallet wallet5 = new Wallet(card9);
            wallet5.addCard(card10);

            Person person3 = new Person(wallet4);
            Person person4 = new Person(wallet5);

            interest.CalculatePersonInterest(person3);
            interest.CalculatePersonInterest(person4);

            Console.WriteLine("-------------TEST 3-------------");
            printInfo.PrintPerson(person3);
            printInfo.PrintPersonWallets(person3);

            printInfo.PrintPerson(person4);
            printInfo.PrintPersonWallets(person4);

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
