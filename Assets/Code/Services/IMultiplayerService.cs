using Photon.Pun;

namespace Code
{
    public interface IMultiplayerService
    {
        void Connect();
        void JoinRoom();
        void CreateRoom();
        void OnJoinedRoom();
        void Disconnect();
    }
}