using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LincolnCardGame
{
    public class Game : Deck
    {
        public void TwoPlayer()
        {
            List<string> playerOneHand = Deal();
            List<string> playerTwoHand = Deal();
        }

        public void OnePlayer()
        {

        }
    }
}
