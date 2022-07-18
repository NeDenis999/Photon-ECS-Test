using System;
using Photon.Pun;
using UnityEngine;

namespace Code.Services
{
    public class PhotonService : IMultiplayerService
    {
        private MonoBehaviourPunCallbacks _monoBehaviourPunCallbacks;

        public PhotonService(EntitasController monoBehaviourPunCallbacks, ref Action action)
        {
            _monoBehaviourPunCallbacks = monoBehaviourPunCallbacks;
            action += OnJoinedRoom;
        }

        public void Connect()
        {
            //_monoBehaviourPunCallbacks.conn;
            PhotonNetwork.ConnectUsingSettings();
            //Debug.Log("Подключение удалось");
            //_monoBehaviourPunCallbacks.OnConnected();
        }

        public void JoinRoom()
        {
            PhotonNetwork.JoinRoom("test");
            //Debug.Log("Подключение к комнате удалось");
        }

        public void CreateRoom()
        {
            PhotonNetwork.CreateRoom("test");
            //Debug.Log("Создание комнаты");
        }

        public void OnJoinedRoom()
        {
            //Debug.Log("Комната созданна");
            PhotonNetwork.LoadLevel("Game");
        }

        public void Disconnect()
        {
            //Debug.Log("Отключение");
            PhotonNetwork.Disconnect();
        }
    }
}