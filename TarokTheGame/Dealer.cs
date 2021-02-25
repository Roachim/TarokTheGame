using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace TarokTheGame
{
    public class Dealer
    {
        public List<ICard> Cards { get; set; }

        public Dealer()
        {
            for (int i = 0; i < 78; i++)
            {
                var mockCard = new Mock<ICard>();

                Cards.Add(mockCard.Object);
            }
        }
        public void DealCards(IPlayer player1, IPlayer player2)
        {
            for (int i = 0; i < 25; i++)
            {
                player1.Cards.Add(Cards[i]);
                player2.Cards.Add(Cards[i+1]);
                Cards.Remove(Cards[i]);
                Cards.Remove(Cards[i]);
            }
        }
        
    }
}
