using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;


namespace MastermindService
{

    class DataHelper 
    {
        private OleDbConnection connection;

        public DataHelper()
        {
            // This is for access to an ACCESS datadase
            String providerInfo = "Provider=Microsoft.ACE.OLEDB.12.0"; //for a accdb-database.

            //String applicationPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            String databaseInfo = "Data Source=" + @"C:\ChessProblemsDatabase.accdb";

            String connectionInfo = providerInfo + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }

        public bool isValidLogin(string playerName, string password)
        {
            bool isValidLogin = false;

            String sql = "SELECT * FROM Player WHERE PlayerName = '" + playerName + "' AND " + "Password = '" + password + "';";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;   
                }
                if (count >= 1)
                    isValidLogin = true;
            }
            catch
            {
                Console.WriteLine("Somting went wrong!");
            }
            finally
            {
                connection.Close();
            }
            return isValidLogin;
        }
        public bool isExistingUser(string username)
        {
            bool isExistingUser = false;

            String sql = "SELECT PlayerName, Password FROM Player WHERE PlayerName = '" + username + ";";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                reader.Read();

                if (reader.GetValue(0) == null)
                    isExistingUser = false;
                else
                    isExistingUser = true;

            }
            catch
            {
                Console.WriteLine("Somting went wrong!");
            }
            finally
            {
                connection.Close();
            }
            return isExistingUser;
        }
        public bool RegisterNewPlayer(string playerName, string password)
        {
            if (!isExistingUser(playerName))
            {
                String sql = "INSERT INTO Player VALUES (" + playerName + "," + password + ");";
                OleDbCommand command = new OleDbCommand(sql, connection);

                string problem = "";

                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    reader.Read();
                    problem = Convert.ToString(reader["Problem"]);
                }
                catch
                {
                    Console.WriteLine("Somting went wrong!");
                }
                finally
                {
                    connection.Close();
                }

                return true;
            }
            else
                return false;
        }
        public List<string> getListOfPlayers()
        {
            List<string> playerList = new List<string>();
            String sql = "SELECT PlayerName, Password FROM Player;";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    playerList.Add(reader.GetData(0).ToString() + " " +reader.GetData(1).ToString());
                }

            }
            catch
            {
                Console.WriteLine("Somting went wrong!");
            }
            finally
            {
                connection.Close();
            }
            return playerList;
        }
        public void UpdatePlayers(List<string> newListOfPlayers)
        {
        }
    }

}
