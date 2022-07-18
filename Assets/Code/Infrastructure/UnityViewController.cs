using Entitas;
using UnityEngine;

namespace Code.Infrastructure
{
    public class UnityViewController : MonoBehaviour, IViewController
    {
        public GameContext Game { get; private set; }
        public GameEntity Entity { get; private set; }
        
        public IViewController InitializeView(GameContext game, IEntity entity)
        {
            Game = game;
            Entity = (GameEntity) entity;
            
            return this;
        }

        public void Destroy()
        {
        }
    }
}