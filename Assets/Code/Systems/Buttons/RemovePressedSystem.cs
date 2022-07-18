using System;
using Entitas;

namespace Code.Systems.Buttons
{
    public class RemovePressedSystem : ICleanupSystem
    {
        private IGroup<GameEntity> _game;
        
        public RemovePressedSystem(GameContext game)
        {
            _game = game.GetGroup(GameMatcher.Pressed);
        }
        
        public void Cleanup()
        {
            foreach (var game in _game)
            {
                game.isPressed = false;
            }
        }
    }
}