using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CcubeDataAccessLayer;
using System.Data;

namespace CcubeLogicLayer
{
    public class Manager //Manages Errything
    {
        static Table[] tables = new Table[9]; 
        static List<Player> playersList = new List<Player>(); 
        static Queue<Player> waitingList = new Queue<Player>();
        static List<Game> gamesList = new List<Game>(); //Games in progress

        public Manager()
        {
            for (int i = 1; i <= 9;i++)
            {
                tables[i-1] = new Table("T-" + i);
            }
            //FetchAllData();


        }

        //Prop
        public static Table[] Tables
        {
            get { return tables; }
        }
        public static Queue<Player> WaitingList
        {
            get { return waitingList; }
        }

        public static List<Player> PlayersList
        {
            get { return playersList; }
        }

        public static List<Game> GamesList
        {
            get { return gamesList; }
            set{ gamesList = value;}
        }
        //Props End


        public int RegisterPlayer(String name, String cnic)
        {
            Player player = new Player(name, cnic);
            DatabaseHandler d = new DatabaseHandler();
            return d.registerUser(name, cnic);
        }

        public static bool QueueIsEmpty() //Waiting Queue Check
        {
            return waitingList.Count == 0; 
        }
         public Player SearchPlayer(string token)
        {
            foreach (Player i in Manager.PlayersList)
            {
                if (token == i.PlayerName) //Found
                {
                    return i;
                }
            }
            return null;
        }

        public bool StartGame(Player p1, Player p2)
         {
             if (getTable() != "-1")
             {
                 Game newGame = new Game();
                 newGame.Player1 = p1;
                 
                 newGame.Player2 = p2;

                 newGame.TableName = getTable();
                 BusyTable();
                 GamesList.Add(newGame);
                 return true;
             }
             return false;
         }

        public string OnePlayerArrived(Player p1)
        {
            if (QueueIsEmpty())
            {
                WaitingList.Enqueue(p1);
                return "Player added in queue.";
            }
            else if (!QueueIsEmpty())
            {
                if (!AllTablesBusy())
                {
                    Game anewGame = new Game();
                    anewGame.Player1 = Manager.WaitingList.Dequeue();
                    anewGame.Player2 = p1;
                    anewGame.TableName = Manager.getTable();
                    Manager.BusyTable();
                    Manager.GamesList.Add(anewGame);
                }
                else if (AllTablesBusy())
                    WaitingList.Enqueue(p1);
                    return "All Tables Busy. Player Added in queue";
            }
            else
                return "ERROR!";
        }


        public static bool AllTablesBusy()
        {
            bool tempBusy = false;
            for (int i = 1; i <= 9; i++)
            {
                tempBusy = Manager.tables[i].Busy;
                if (tempBusy == false)
                    return false;
            }
            return true;

        }

        public static string getTable() //Returns table id if table is available, or -1
        {
            
			for (int i = 0; i <= 9; i++)
			{
                if (!Manager.tables[i].Busy)
                    return Manager.tables[i].TableID;
			}
            Console.WriteLine("All tables Busy");
            Console.ReadLine();
            return "-1";
        }

        public static void BusyTable() //Mark available table as busy
        {
            for (int i = 0; i < 9; i++)
            {
                if (!Manager.tables[i].Busy)
                {
                    Manager.tables[i].Busy = true;
                    return;
                }
                
            }
        }

        public static void DeclareResult()
        {
            int counter = 0;
            Console.WriteLine("Choose Game by entering number!");

            for (int i = 1; i <= gamesList.Count; i++)
            {
				Console.WriteLine(i);

                Console.WriteLine("GAme ID: {0}",gamesList[i-1].GameID);
				Console.WriteLine("Table: {0} ", gamesList[i-1].TableName);
				Console.WriteLine("Player 1: {0} ", gamesList[i-1].Player1.PlayerName);
                counter = i;
				/*Console.WriteLine("Player 2: {0} ", gamesList[i].Player2.PlayerName);*/
			}

            int choice = 0;
            int temp = int.Parse(Console.ReadLine());
            if (temp > 0 && temp <= counter)
                choice = temp;
            else
            {
                Console.WriteLine("Invalid Input!");
                Console.ReadLine();
            }
            

            gamesList[choice - 1].Player1.GamesPlayed++;
            gamesList[choice - 1].Player2.GamesPlayed++;


            Console.WriteLine("Enter Winner ID:");
            Console.WriteLine("player 1 ID:{0}", gamesList[choice - 1].Player1.PlayerID);
            Console.WriteLine("player 2 ID:{0}", gamesList[choice - 1].Player2.PlayerID);
            int winChoice = int.Parse(Console.ReadLine());
            gamesList[choice - 1].WinnerID = winChoice;
            if (winChoice == gamesList[choice - 1].Player1.PlayerID)
            {
                gamesList[choice - 1].Player1.GamesWon++;
                gamesList[choice - 1].Player2.GamesLost++;
            }
            else if (winChoice == gamesList[choice - 1].Player2.PlayerID)
            {
                gamesList[choice - 1].Player2.GamesWon++;
                gamesList[choice - 1].Player1.GamesLost++;
            }
            
            gamesList[choice - 1].GameEnd();
            for (int i = 0; i < 9; i++)
            {
                if (gamesList[choice - 1].TableName == Manager.tables[i].TableID)
                    Manager.tables[i].Busy = false;
            }
            gamesList.RemoveAt(choice - 1);
		}

		/*public static void FetchAllData() //Reads player's file and store in players list
        {
            //StreamReader playerReader = new StreamReader("players.txt");

            while (true)
            {
                
                Player tempPlayer = new Player();
                string line;
                line = playerReader.ReadLine();
                if (line == null)
                    break;
                tempPlayer.PlayerID = int.Parse(line);
                tempPlayer.PlayerName = playerReader.ReadLine();
                tempPlayer.CNIC = playerReader.ReadLine();
                tempPlayer.GamesPlayed = int.Parse(playerReader.ReadLine());
                tempPlayer.GamesLost = int.Parse(playerReader.ReadLine());
                tempPlayer.GamesWon = int.Parse(playerReader.ReadLine());

                playersList.Add(tempPlayer);
                Player.PlayerCounter = tempPlayer.PlayerID;
            }
             
            playerReader.Close();

        }

        public void FetchAllData()
        {
            int i = 0;
            DatabaseHandler d = new DatabaseHandler();
            DataSet ds = d.GetPlayersData();
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                playersList[i].PlayerID = int.Parse(dr[i].ToString());
                playersList[i].CNIC = dr["CNIC"].ToString();
                playersList[i].GamesPlayed = int.Parse(dr["GamesPlayed"].ToString());
                playersList[i].GamesWon = int.Parse(dr["GamesWon"].ToString());
                playersList[i].GamesLost = int.Parse(dr["GamesLost"].ToString());

                i++;
            }
        }*/
	}
}
