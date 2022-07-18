using System;
using Photon.Pun;

namespace Code
{
    public class TestConnectedLoadScene : MonoBehaviourPunCallbacks
    {
        public override void OnJoinedRoom()
        {
            PhotonNetwork.LoadLevel("Game");
        }
    }
}