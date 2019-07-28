using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcubeLogicLayer
{
    public class FacadeController
    {
        Manager mgr = new Manager();
        private FacadeController() { }
        public static FacadeController instance = null;

        public static FacadeController getFController()
        {
            if (instance == null)

                instance = new FacadeController();
            return instance;
        }

        public int RegisterPlayer(String name, String cnic)
        {
            return mgr.RegisterPlayer(name, cnic);
        }
        public Player SearchPlayer(string token)
        {
            return mgr.SearchPlayer(token);
        }

        public bool GameStatus() //Games Happening
        {
            if (Manager.GamesList.Count != 0)
                return true;
            else
                return false;
        }

        public int CountGames()
        {
            int counter = 0;
            if(GameStatus())
            { 
                for (int i = 1; i <= Manager.GamesList.Count; i++)
                    counter++;  
            }
            return counter;
        }
        public List<Game> GetGames()
        {
            return Manager.GamesList;
        }

        public List<Player> GetPlayers()
        {
            return Manager.PlayersList;
        }

        public bool StartGame(Player p1, Player p2)
        {
            return mgr.StartGame(p1, p2);
        }

        public string OnePlayerArrived(Player p1)
        {
            return mgr.OnePlayerArrived(p1);
        }

        public void FreeTable(string tableName, List<Game> newList, int gameNo)
        {
            for (int i = 0; i < 9; i++)
            {
                if (newList[gameNo].TableName == Manager.Tables[i].TableID)
                    Manager.Tables[i].Busy = false;
            }
            Manager.GamesList = newList;        //update list
            Manager.GamesList.RemoveAt(gameNo); //Removes game from list
        }

        public Table[] GetTableStatus()
        {
            Table[] temp = Manager.Tables;
            return temp;
        }
    }
}
