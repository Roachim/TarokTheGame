using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarokTheGame;
using Moq;

namespace TarokTheGameTesting
{
    [TestClass]
    public class DealerTest
    {
        [TestMethod]
        public void TestDealerDealing()
        {
            //arrange
            int expectedResult = 25;
            Dealer dealer = new Dealer();
            var mockPlayer1 = new Mock<IPlayer>();
            var mockPlayer2 = new Mock<IPlayer>();

            mockPlayer1.SetupAllProperties();
            mockPlayer2.SetupAllProperties();

            IPlayer player1 = mockPlayer1.Object;
            IPlayer player2 = mockPlayer2.Object;


            //act
            dealer.DealCards(player1, player2);

            //assert
            Assert.AreEqual(expectedResult, dealer.Cards.Count);
            Assert.AreEqual(expectedResult, player1.Cards.Count);
            Assert.AreEqual(expectedResult, player2.Cards.Count);
        }
    }
}
