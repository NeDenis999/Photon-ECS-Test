using System;
using Code.Services;
using Code.Systems;
using Photon.Pun;
using UnityEngine;

namespace Code
{
    public class EntitasController : MonoBehaviourPunCallbacks
    {
        private Entitas.Systems _systems;
        private Services.Services _services;

        private event Action JoinedRoom;
        
        private void Awake()
        {
            _services = new Services.Services
            {
                MultiplayerService = new PhotonService(this, ref JoinedRoom),
                CoroutineService = new UnityCoroutineService(this)
            };

            Contexts contexts = Contexts.sharedInstance;

            _systems = new AllSystems(contexts, _services);
        }

        private void Start()
        {
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
        
        public override void OnJoinedRoom()
        {
            JoinedRoom?.Invoke();
            base.OnJoinedRoom();
        }

        private void OnApplicationQuit()
        {
            _services.MultiplayerService.Disconnect();
        }
    }
}
