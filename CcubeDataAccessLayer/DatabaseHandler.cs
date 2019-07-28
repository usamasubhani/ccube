using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CcubeDataAccessLayer
{
    public class DatabaseHandler
    {
        public int registerUser(string name, string cnic)
        {
            ConnectToDatabase c = new ConnectToDatabase();
            c.ConnectToDB();
            string query = @" INSERT INTO Players (PName, CNIC) VALUES('" + name + "','" + cnic + "')";
            return c.UpdateQuery(query);
        }

        public DataSet GetPlayersData() //return all players data
        {
            string query = @"SELECT [PlayerID], [PName], [CNIC], [GamesPlayed], [GamesWon], [GamesLost] FROM [CCUBE].[dbo].[Players]";
            ConnectToDatabase c = new ConnectToDatabase();
            c.ConnectToDB();
            return c.ExceuteQuerySet(query);
        }
    }
}
