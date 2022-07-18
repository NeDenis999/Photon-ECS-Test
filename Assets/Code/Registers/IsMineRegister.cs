using Photon.Pun;
using UnityEngine;

namespace Code.Registers
{
    [RequireComponent(typeof(PhotonView))]
    public class IsMineRegister : MonoBehaviourPunCallbacks, IViewComponentRegistrator
    {
        public void Register(GameEntity entity) => 
            entity.isMine = photonView.IsMine;
    }
}