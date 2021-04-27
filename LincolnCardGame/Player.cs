namespace LincolnCardGame
{
    public class Player
    {
        public int playerWins;
        public int playerTurn;
        public int PlayerWin()
        {
            playerWins += 1;
            playerTurn = 1;
            return playerWins;
        }

        public int PlayerLose()
        {
            playerTurn = 0;
            return playerTurn;
        }
    }
}
