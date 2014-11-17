using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


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
            String databaseInfo = "Data Source=" + @"C:\MastermindDatabase.accdb";

            String connectionInfo = providerInfo + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }

        public bool isValidLogin(string playerName, string password)
        {
            bool isValidLogin = false;

            String sql = "SELECT PlayerName, Password FROM Player WHERE playerName = '" + playerName + "' AND " + "password = '" + password + "';";
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

            String sql = "SELECT PlayerName, Password FROM Player WHERE PlayerName = '" + username + "';";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    isExistingUser = true;
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
            return isExistingUser;
        }
        public bool RegisterNewPlayer(string playerName, string password)
        {
            if (!isExistingUser(playerName))
            {
                String sql = "INSERT INTO Player (playername,password) VALUES ('" + playerName + "' , '" + password + "');";
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Connection = connection;


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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
        public List<MastermindService.Player> getListOfPlayers()
        {
            List<MastermindService.Player> playerList = new List<MastermindService.Player>();
            String sql = "SELECT PlayerName, Password FROM Player;";
            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    playerList.Add(new MastermindService.Player(reader.GetData(0).ToString(), reader.GetData(1).ToString()));
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
        public void UpdatePlayers(List<MastermindService.Player> newListOfPlayers)
        {
        }
    }

}
