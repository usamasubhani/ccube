using System;
using System.IO;
using CcubeDataAccessLayer;
namespace CcubeLogicLayer
{
    public class Player
    {
        static int playerCounter = 0;
        int playerID;
        private string playerName;
        private string cnic;
        private int gamesPlayed;
        private int gamesWon;
        private int gamesLost;

        public Player(){}

        public Player(string name, string cnic) //Constructor
        {
            playerCounter++;
            playerID = playerCounter;
            this.playerName = name;
            this.CNIC = cnic;
            gamesPlayed = gamesLost = gamesWon = 0;
            Manager.PlayersList.Add(this);



            /*StreamWriter playerFile = new StreamWriter("players.txt", append: true);

            playerFile.WriteLine(playerID);
            playerFile.WriteLine(name);
            playerFile.WriteLine(cnic);
            playerFile.WriteLine(gamesPlayed);
            playerFile.WriteLine(gamesLost);
            playerFile.WriteLine(gamesWon);

            playerFile.Close();*/
        }


        //Properties
        public static int PlayerCounter
        {
            get { return playerCounter; }
            set { playerCounter = value; }
        }

        public int PlayerID
        {
            get { return playerID; }
            set { playerID = value; }
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }
        }
        public int GamesPlayed
        {
            get { return gamesPlayed; }
            set { gamesPlayed = value; }
        }
		public int GamesWon
		{
			get { return gamesWon; }
			set { gamesWon = value; }
		}
		public int GamesLost
		{
			get { return gamesLost; }
			set { gamesLost = value; }
		}



    }
}
