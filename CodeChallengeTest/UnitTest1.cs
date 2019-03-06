using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace CodeChallengeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void TestNegativeBalance()
        {
            //Arrange
            var calInterest = new ConsoleApplication1.CalculateInterest(); 
            double balance = -10;
            string type = "VISA";
            double interest = 0; 

            var card = new Card(balance, type);

            //Act 
            interest = calInterest.CalculateCardInterest(card);

            //Assert 
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void TestNonValidCardType()
        {
            //Arrange
            var calInterest = new ConsoleApplication1.CalculateInterest();
            double balance = 10;
            string type = "CHASE";
            double interest = 0;

            var card = new Card(balance, type);

            //Act 
            interest = calInterest.CalculateCardInterest(card);

            //Assert 
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateValidInterestCard()
        {
            //Arrange
            var calInterest = new ConsoleApplication1.CalculateInterest();
            double balance = 100;
            string type = "VISA";
            double interest = 0;

            var card = new Card(balance, type);

            //Act 
            interest = calInterest.CalculateCardInterest(card);

            //Assert
            Assert.AreEqual(interest, 10);
        }

        [TestMethod]
        public void CalculateValidInterestWallet()
        {
            //Arrange
            var calInterest = new ConsoleApplication1.CalculateInterest();
            double balance1 = 100;
            string type1 = "VISA";
            double balance2 = 100;
            string type2 = "MASTER CARD";

            var card1 = new Card(balance1, type1);
            var card2 = new Card(balance2, type2);
            var wallet = new Wallet(card1);
            wallet.addCard(card2);

            //Act 
            double interest = calInterest.CalculateWalletInterest(wallet);

            //Assert
            Assert.AreEqual(interest, 15);
        }

        [TestMethod]
        public void CalculateValidInterestPerson()
        {
            //Arrange
            var calInterest = new ConsoleApplication1.CalculateInterest();
            double balance1 = 100;
            string type1 = "VISA";
            double balance2 = 100;
            string type2 = "MASTER CARD";
            double balance3 = 100;
            string type3 = "DISCOVER";

            var card1 = new Card(balance1, type1);
            var card2 = new Card(balance2, type2);
            var card3 = new Card(balance3, type3);
            var wallet = new Wallet(card1);
            wallet.addCard(card2);
            wallet.addCard(card3);

            var person = new Person(wallet);

            //Act 
            calInterest.CalculatePersonInterest(person);

            //Assert
            Assert.AreEqual(person.interest, 16);
        }
    }
}
