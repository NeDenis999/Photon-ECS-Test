using Code.Systems.ServiceRegistration;

namespace Code.Systems
{
    public class ServiceRegistrationSystems : Feature
    {
        public ServiceRegistrationSystems(Contexts contexts, Services.Services services) : base(
            nameof(ServiceRegistrationSystems))
        {
            GameContext game = contexts.game;
            InputContext input = contexts.input;
            MetaContext meta = contexts.meta;

            Add(new RegisterServiceSystem<IMultiplayerService>(services.MultiplayerService, meta.ReplaceMultiplayer));
            Add(new RegisterServiceSystem<ICoroutineService>(services.CoroutineService, meta.ReplaceCoroutine));
        }
    }
}