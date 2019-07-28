using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;


namespace CcubeDataAccessLayer
{
   public  class ConnectToDatabase
    {


        private SqlConnection DBConnection;
        private SqlDataAdapter DataAdapter;
        private DataSet ResultSet;
        private SqlCommand QueryCommand;
        private SqlDataReader QueryResultReader;

        public ConnectToDatabase() { }



        public void ConnectToDB()
        {
            DBConnection = new SqlConnection(@"Data Source=PC-1\SQLEXPRESS;Initial Catalog=CCUBE;Integrated Security=True");
            DBConnection.Open();
            ResultSet = new DataSet();
        }




        public DataSet ExceuteQuerySet(String Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet, "myTable");
            DataAdapter.Dispose();
            return ResultSet;
        }

        public SqlDataReader ExceuteQuery(String Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            QueryResultReader = QueryCommand.ExecuteReader();
            QueryCommand.Dispose();
            return QueryResultReader;
        }

        public int UpdateQuery(String Query)
        {

            QueryCommand = new SqlCommand(Query, DBConnection);
            int Result = QueryCommand.ExecuteNonQuery();
            QueryCommand.Dispose();

            return Result;

        }

        public int UpdateQuerySet(DataSet ds, String Query)
        {
            DataAdapter = new SqlDataAdapter(Query, DBConnection);
            DataAdapter.Fill(ResultSet);
            ResultSet = ds.Copy();
            int Result = DataAdapter.Update(ResultSet);
            DataAdapter.Dispose();
            return Result;
        }

        public object SpecificQuery(String Query)
        {
            QueryCommand = new SqlCommand(Query, DBConnection);
            object Result = QueryCommand.ExecuteScalar();
            QueryCommand.Dispose();
            return Result;
        }

        public void CloseConnection()
        {
            DBConnection.Close();
        }
    }
}
