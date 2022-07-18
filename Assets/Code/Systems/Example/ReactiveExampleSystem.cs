using System.Collections.Generic;
using Entitas;

namespace Code.Systems.Example
{
    public class ReactiveExampleSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _game;

        public ReactiveExampleSystem(GameContext game) : base(game)
        {
            _game = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Mine));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Mine);

        protected override bool Filter(GameEntity game) => game.isMine;

        protected override void Execute(List<GameEntity> _gameEntities)
        {
            foreach (GameEntity game in _game.GetEntities())
            {
                
            }
        }
    }
}