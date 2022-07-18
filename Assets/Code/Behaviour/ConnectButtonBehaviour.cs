using Code.Infrastructure;
using Entitas;

namespace Code.Behaviour
{
    public class ConnectButtonBehaviour : EntityBehaviour
    {
        protected override void OnStart()
        {
            Entity.isConnectButton = true;
        }
    }
}