using Code.Infrastructure;

namespace Code.Behaviour
{
    public class CreateRoomButtonBehaviour : EntityBehaviour
    {
        protected override void OnStart()
        {
            Entity.isCreateRoomButton = true;
        }
    }
}