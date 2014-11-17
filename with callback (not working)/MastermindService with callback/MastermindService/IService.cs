using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MastermindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required, Namespace = "MastermindService", CallbackContract = typeof(IService1Callback))]
    public interface IService
    {
        [OperationContract]
        bool Login(string playerName, string password);

        [OperationContract]
        void Logout(string playerName);

        [OperationContract]
        void RegisterNewPlayer(string name, string pass);

        [OperationContract]
        List<string> GetRoomList();

        [OperationContract]
        List<string> GetListOfPlayers();

        [OperationContract]
        List<string> GetPlayersInRoom(string RoomName);

        [OperationContract]
        bool PlayerJoinRoom(string playerName, string roomName);

        [OperationContract]
        void PlayerCreateRoom(string playerName);

        [OperationContract]
        void PlayerLeaveRoom(string playerName, string roomName);

        [OperationContract]
        void PlayerLeavePortal(string playerName);

        [OperationContract]
        List<int> GetHiddenNumber(string RoomName);

        [OperationContract]
        List<String> GetGuessResults(List<int> guessNumbers, string roomName);

        [OperationContract]
        void StartNewGame(string RoomName);

        [OperationContract]
        void GameOver(string roomName);
    }
    public interface IService1Callback
    {
        [OperationContract(IsOneWay = true)]
        void gameFinished(string resulOfGame);
    }
    [DataContract]
    public class Player
    {
        //FIELDS
        private string name;
        private string password;
        //private DateTime RegDate;
        [DataMember]
        public string currentRoom;
        //public List<int> lastGuess;
        [DataMember]
        public string feedback;

        //PROPERTIES
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public IService1Callback gameFinishedCallback { get; set; }
        //public List<List<int>> listOfCurrentGameGuesses;

        //CONSTRUCTOR
        public Player(string name, string password)
        {
            this.name = name;
            this.password = password;
            //this.RegDate = DateTime.Today;
            this.currentRoom = null;
            //this.lastGuess = new List<int>();
        }
        //METHODS
        //public bool JoinRoom(Room roomToJoin) { return false; }
        //public bool LeaveRoom() { return false; }
        //public IGameCallback
    }
}
