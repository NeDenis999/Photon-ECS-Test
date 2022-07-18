using Entitas;
using UnityEngine;

namespace Code.Systems.Example
{
    public class InitializationExampleSystem : IInitializeSystem
    {
        private readonly IGroup<GameEntity> _game;

        public InitializationExampleSystem(GameContext game)
        {
            _game = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Mine));
        }
        
        public void Initialize()
        {
            foreach (var game in _game)
            {
                
            }
        }
    }
}