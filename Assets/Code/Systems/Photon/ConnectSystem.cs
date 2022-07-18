using Entitas;
using Photon.Pun;
using UnityEngine;

namespace Code.Systems
{
    public class ConnectSystem : IInitializeSystem
    {
        private readonly IGroup<MetaEntity> _meta;

        public ConnectSystem(MetaContext meta)
        {
            _meta = meta.GetGroup(MetaMatcher
                .AllOf(MetaMatcher.Multiplayer));
        }
        
        public void Initialize()
        {
            //Debug.Log("Initialize");
            
            foreach (var meta in _meta)
            {
                //Debug.Log("metaConnect");
                var nickName = "Player" + Random.Range(1000, 9999);

                PhotonNetwork.NickName = nickName;
                PhotonNetwork.AutomaticallySyncScene = true;
                PhotonNetwork.GameVersion = "1";
                meta.multiplayer.Value.Connect();
            }
        }
    }
}