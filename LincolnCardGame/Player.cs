namespace LincolnCardGame
{
    public class Player
    {
        public int playerWins;
        public bool playerTurn;
        public void PlayerWin()
        {
            playerWins += 1;
            playerTurn = true;
        }

        public void PlayerLose()
        {
            playerTurn = false;            
        }
    }
}
