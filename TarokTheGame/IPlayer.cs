using System;
using System.Collections.Generic;
using System.Text;

namespace TarokTheGame
{
    public interface IPlayer
    {
        List<ICard> Cards { get; set; }
    }
}
