using System;
using Code.Systems.Buttons;
using Code.Systems.Hero;
using Code.Systems.Input;
using Code.Systems.Photon;

namespace Code.Systems
{
    public class AllSystems : Entitas.Systems
    {
        public AllSystems(Contexts contexts, Services.Services services)
        {
            Add(new ServiceRegistrationSystems(contexts, services));
            Add(new InputSystems(contexts));
            Add(new ConnectSystem(contexts.meta));
            Add(new SpawnHeroSystem(contexts.game));
            Add(new ConnectButtonSystem(contexts.game, contexts.meta));
            Add(new CreateRoomButtonSystem(contexts.game, contexts.meta));
            Add(new HeroMove(contexts.game, contexts.input));
            
            //Cleanup
            Add(new RemovePressedSystem(contexts.game));
        }
    }
}