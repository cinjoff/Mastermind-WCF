using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MastermindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MastermindService : IService
    {
        List<Room> Roomlist;
        List<Player> Playerlist;
        DataHelper dataHelper;
        public MastermindService()
        {
            dataHelper = new DataHelper();
            Roomlist = new List<Room>();
            Playerlist = dataHelper.getListOfPlayers();//TO-DO get the list of players from database
        }
        //LOCAL METHODS
        public Room getRoomByName(string RoomName)
        {
            foreach (Room r in this.Roomlist)
            {
                if (r.OwnerName == RoomName)
                    return r;

            }
            return null;
        }
        public Player getPlayerByName(string playerName)
        {
            foreach (Player p in Playerlist)
            {
                if (p.Name == playerName)
                    return p;
            }
            return null;
        }
        //SERVER METHODS


        public bool Login(string playerName, string password)
        {
            if (dataHelper.isValidLogin(playerName, password))
            {
                this.Playerlist.Add(new Player(playerName, password));
                //SEND PLAYER JOINED PORTAL CALLBACK
                return true;
            }
            else
            {
                this.Playerlist.Add(new Player(playerName, password));
                return false;

            }
            
        }

        public void Logout(string playerName)
        {
            this.Playerlist.Remove(getPlayerByName(playerName));
            //SEND PLAYER LEFT CALLBACK
        }

        public bool RegisterNewPlayer(string name, string pass)
        {

            if (dataHelper.RegisterNewPlayer(name, pass))
                return true;
            else
                return false;
            
        }

        public List<string> GetRoomList()
        {
            List<string> roomList = new List<string>();
            foreach (Room r in Roomlist)
            {
                roomList.Add(r.OwnerName);
            }
            return roomList;
        }

        public List<string> GetListOfPlayers()
        {
            List<string> playerList = new List<string>();
            foreach (Player p in this.Playerlist)
            {
                playerList.Add(p.Name);
            }
            return playerList;
        }

        public List<string> GetPlayersInRoom(string RoomName)
        {
            List<string> playersList = new List<string>();
            foreach (Player p in getRoomByName(RoomName).playersIn)
            {
                playersList.Add(p.Name);
            }
            return playersList;
        }

        public bool PlayerJoinRoom(string playerName, string roomName)
        {
            Room roomToJoin = getRoomByName(roomName);
            if (!roomToJoin.IsFull())
            {
                roomToJoin.playersIn.Add(getPlayerByName(playerName));
                //TODO - SEND CALLBACK TO PLAYERS IN THAT GAME 
                return true;
            }
            return false;
        }

        public void PlayerCreateRoom(string playerName)
        {
            Player owner = this.getPlayerByName(playerName);
            Room newRoom = new Room(owner);
            this.Roomlist.Add(newRoom);
            getPlayerByName(owner.Name).currentRoom = newRoom;
            newRoom.playersIn.Add(owner);
            //TODO CALLBACK to all other players to update the roomlist
        }

        public void PlayerLeaveRoom(string playerName, string roomName)
        {
            Player playerToLeave = this.getPlayerByName(playerName);
            Room roomToLeave = this.getRoomByName(roomName);
            if (playerToLeave != null && roomName != null)
            {
                roomToLeave.playersIn.Remove(playerToLeave);
            }
            if (roomToLeave.playersIn.Count == 0)
                Roomlist.Remove(roomToLeave);
        }

        public void PlayerLeavePortal(string playerName)
        {
            Player playerToRemove= this.getPlayerByName(playerName);
            if (playerToRemove !=null)
            this.Playerlist.Remove(playerToRemove);
        }

        public void PlayerLeavePortal(string playerName, string roomName)
        {
            Room roomToLeave = getRoomByName(roomName);
            roomToLeave.playersIn.Remove(getPlayerByName(playerName));
            //TODO - SEND CALLBACK TO PLAYERS IN THAT GAME 
            if (roomToLeave.playersIn.Count == 0)
            {
                Roomlist.Remove(roomToLeave);
            }
        }

        public List<int> GetHiddenNumber()
        {
            throw new NotImplementedException();
        }

        public List<String> GetGuessResults(List<int> guessNumbers, string roomName)
        {
            Room selectedRoom = new Room(new Player("-1","-1"));
            selectedRoom = getRoomByName(roomName);
            if (selectedRoom != null)
            {
                int countPosHN = 0;
                int countPosGN;
                String myRigthGuess;
                List<String> myGuessResults = new List<String>();

                foreach (int n in selectedRoom.currentGame.HiddenNumbers)
                {
                    countPosHN++;
                    countPosGN = 0;
                    foreach (int nb in guessNumbers)
                    {
                        countPosGN++;
                        if (n == nb && countPosHN == countPosGN)
                        {
                            myRigthGuess = "A";
                            myGuessResults.Add(myRigthGuess);
                        }
                        else if (n == nb)
                        {
                            myRigthGuess = "B";
                            myGuessResults.Add(myRigthGuess);
                        }
                    }
                }
                myGuessResults.Sort();
                return myGuessResults;
            }
            return null;
        }
        

        public void StartNewGame(string RoomName)
        {
            Room r = this.getRoomByName(RoomName);
            if (r != null)
            {
                r.currentGame = new Game();
            }
        }

        //CLASSES
        public class Game
        {
            //FIELDS
            public List<int> HiddenNumbers;
            private Random randomN;
            public string state;

            //CONSTRUCTOR
            public Game()
            {
                HiddenNumbers = new List<int>();
                randomN = new Random();
                FillHiddenNList();
                this.state = "playing";
            }

            //METHODS
            public int NewRandomNumber()
            {
                int i = randomN.Next(0, 9);
                return i;
            }
            public void FillHiddenNList()
            {
                bool isAllready;
                while (HiddenNumbers.Count < 4)
                {
                    isAllready = false;
                    int numb = NewRandomNumber();
                    if (HiddenNumbers.Count == 0)
                    {
                        HiddenNumbers.Add(numb);
                    }
                    else
                    {
                        foreach (int n in HiddenNumbers)
                        {
                            if (n == numb)
                            {
                                isAllready = true;
                            }
                        }
                        if (!isAllready)
                        {
                            HiddenNumbers.Add(numb);
                        }
                    }
                }
            }
        }
        public class Room
        {
            //FIELDS
            public string OwnerName;
            public int limitOfPlayers;
            public List<Player> playersIn;
            public List<Game> listOfGames;
            public Game currentGame;
            public Room(Player owner)
            {
                this.OwnerName = owner.Name;
                this.playersIn = new List<Player>();
                this.listOfGames = new List<Game>();//TODO - Place IGame in IServer; SIZE - numOFPlayers
                this.limitOfPlayers = 10;
                //currentGame = new IGame(); IGame doesnt have constructor yet
            }
            //METHODS
            public bool IsFull() { return false; }
            public bool CheckPlayerGuess(Player guessingPlayer) { return false; }
            public bool StartNewGame() { return false; }


        }
        public class Player
        {
            //FIELDS
            private string name;
            private string password;
            private DateTime RegDate;
            public Room currentRoom;
            public List<int> lastGuess;
            public List<string> feedback;

            //PROPERTIES
            public string Name
            {
                get
                {
                    return this.name;
                }
            }
            public List<List<int>> listOfCurrentGameGuesses;

            //CONSTRUCTOR
            public Player(string name, string password)
            {
                this.name = name;
                this.password = password;
                this.RegDate = DateTime.Today;
                this.currentRoom = null;
                this.lastGuess = new List<int>();
            }
            //METHODS
            public bool JoinRoom(Room roomToJoin) { return false; }
            public bool LeaveRoom() { return false; }
        }


    }
}
