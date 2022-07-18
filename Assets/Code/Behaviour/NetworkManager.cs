using Code.Expansion;
using Photon.Pun;
using Photon.Realtime;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

namespace Code.Behaviour
{
    public class NetworkManager : MonoBehaviourPunCallbacks
    {
        private const string MenuSceneName = "Menu";
        private const string _heroPath = "PhotonPrefabs\\Hero";
        
        [SerializeField]
        private Transform[] _spawnPoints;

        public override void OnLeftRoom() => 
            SceneManager.LoadScene(MenuSceneName);

        public void Leave() => 
            PhotonNetwork.LeaveRoom();

        public override void OnPlayerEnteredRoom(Player newPlayer) => 
            Debug.Log($"Player {newPlayer.NickName} entered room");

        public override void OnPlayerLeftRoom(Player otherPlayer) => 
            Debug.Log($"Player {otherPlayer.NickName} leave room");

        public void SpawnHero()
        {
            var spawnPoints = _spawnPoints.ToVector2();
            var spawnPoint = spawnPoints[Random.Range(0, _spawnPoints.Length)];
            PhotonNetwork.Instantiate(_heroPath, spawnPoint, quaternion.identity, 0);
        }
    }
}