using System;
using System.IO;
namespace CcubeLogicLayer
{
    public class Game
    {
        long gameID;
        string tableName;
        DateTime startTime;
        Player player1;
        Player player2;
        int winnerID;
        static long gameCounter = 0;

        public Game()
        {
            gameCounter++;
            gameID = gameCounter;
            startTime = DateTime.Now;

        }

        public long GameCounter
        {
            set { gameCounter = value; }
        }
        public long GameID
        {
            get { return gameID; }
            set { gameID = value; }
        }
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public Player Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
		public Player Player2
		{
			get { return player2; }
			set { player2 = value; }
		}
        public int WinnerID
        {
            get { return winnerID; }
            set { winnerID = value; }
        }

        public void GameEnd()  //saves info to file =(
        {
            StreamWriter gameWrite = new StreamWriter("games.txt", append: true);
            gameWrite.WriteLine(gameID);
            gameWrite.WriteLine(tableName);
            gameWrite.WriteLine(startTime);
            gameWrite.WriteLine(winnerID);
            gameWrite.Close();
            GameCounter = gameCounter;
        }


    }
}
