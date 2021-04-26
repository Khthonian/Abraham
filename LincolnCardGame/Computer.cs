using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LincolnCardGame
{
    class Computer : Player, IPlayerCard
    {
        public int WinCounter { get; }
    }
}
