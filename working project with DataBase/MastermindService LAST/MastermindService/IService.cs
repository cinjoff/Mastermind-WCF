using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MastermindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool Login(string playerName, string password);

        [OperationContract]
        void Logout(string playerName);

        [OperationContract]
        bool RegisterNewPlayer(string name, string pass);

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
        List<int> GetHiddenNumber();

        [OperationContract]
        List<String> GetGuessResults(List<int> guessNumbers, string roomName);

        [OperationContract]
        void StartNewGame(string RoomName);
    }
}
