using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Code.Systems.Hero
{
    public class HeroMove : ReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _game;

        public HeroMove(GameContext game, InputContext input) : base(input)
        {
            _game = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Mine, GameMatcher.Hero, GameMatcher.Position, GameMatcher.Speed, GameMatcher.Rigidbody2D));
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context) =>
            context.CreateCollector(InputMatcher.Horizontal);

        protected override bool Filter(InputEntity entity) => 
            entity.hasHorizontal;

        protected override void Execute(List<InputEntity> _input)
        {
            foreach (InputEntity input in _input)
            foreach (GameEntity game in _game.GetEntities())
            {
                var horizontal = input.horizontal.Value;
                
                if (horizontal == 0)
                    continue;
                
                var speed = game.speed.Value;
                var x = horizontal * speed * Time.deltaTime;
                var direction = new Vector2(x, 0);
                
                game.rigidbody2D.Value.position += direction;
            }
        }
    }
}