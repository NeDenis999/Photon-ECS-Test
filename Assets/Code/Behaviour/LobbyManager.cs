using System.Collections;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Code.Behaviour
{
    public class LobbyManager : MonoBehaviourPunCallbacks
    {
        private const string _heroPath = "PhotonPrefabs\\Hero";
        
        public TextMeshProUGUI TextMeshProUGUI;
        public Button CreateRoomButton;
        public Button JoinRoomButon;
        public Button ExitRoomButon;
        public Transform[] SpawnPoints;
        public HeroBehaviour Hero;
        
        private void Start()
        {
            //DontDestroyOnLoad(this.gameObject);
            
            CreateRoomButton.interactable = false;
            JoinRoomButon.interactable = false;
            ExitRoomButon.interactable = false;
            
            PhotonNetwork.NickName = "Player" + Random.Range(1000, 9999);
            Log("Players name is set to " + PhotonNetwork.NickName);
            
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.GameVersion = "1";
            PhotonNetwork.ConnectUsingSettings();
        }

        public override void OnConnectedToMaster()
        {
            Log("Подключение удалось");

            CreateRoomButton.interactable = true;
            JoinRoomButon.interactable = true;
            ExitRoomButon.interactable = true;
        }

        public void CreateRoom()
        {
            DontDestroyOnLoad(this.gameObject);
            PhotonNetwork.CreateRoom(null, new Photon.Realtime.RoomOptions { MaxPlayers = 4 });
        }

        public void JoinRoom()
        {
            PhotonNetwork.JoinRandomRoom();
        }

        public override void OnJoinedRoom()
        {
            Log("Joined the room");
            //Spawn();
            
            if (PhotonNetwork.IsMasterClient)
                PhotonNetwork.LoadLevel("Game");
            //StartCoroutine(AsyncLoadScene());
        }

        private void Spawn()
        {
            print("spawn");
            var hero = PhotonNetwork.Instantiate(_heroPath, Vector2.zero, Quaternion.identity);
            DontDestroyOnLoad(hero);
        }

        private IEnumerator AsyncLoadScene()
        {
            yield return new WaitForSeconds(1);
            Spawn();
        }

        public void Exit()
        {
            Application.Quit();
        }

        public override void OnJoinRoomFailed(short returnCode, string message)
        {
            base.OnJoinRoomFailed(returnCode, message);
        }

        private void Log(string message)
        {
            TextMeshProUGUI.text += '\n';
            TextMeshProUGUI.text += message;
        }
    }

    public class SpawnPoint : MonoBehaviour
    {
    }
}