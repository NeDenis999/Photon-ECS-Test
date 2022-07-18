using Entitas;
using Photon.Pun;
using UnityEngine;

namespace Code.Systems.Photon
{
    public class CreateHeroNickNameSystem : IInitializeSystem
    {
        private readonly IGroup<GameEntity> _game;

        public CreateHeroNickNameSystem(GameContext game)
        {
            _game = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Mine, GameMatcher.Hero));
        }
        
        public void Initialize()
        {
            foreach (var game in _game)
            {
                game.AddNickName(PhotonNetwork.NickName);
            }
        }
    }
}