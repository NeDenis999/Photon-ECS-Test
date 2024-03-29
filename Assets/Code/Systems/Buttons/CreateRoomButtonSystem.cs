﻿using System.Collections.Generic;
using Entitas;

namespace Code.Systems.Buttons
{
    public class CreateRoomButtonSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<MetaEntity> _meta;

        public CreateRoomButtonSystem(GameContext game, MetaContext meta) : base(game)
        {
            _meta = meta.GetGroup(MetaMatcher.AllOf(MetaMatcher.Multiplayer));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
            context.CreateCollector(GameMatcher.Pressed);

        protected override bool Filter(GameEntity game) => 
            game.isCreateRoomButton && game.isPressed;

        protected override void Execute(List<GameEntity> _gameEntities)
        {
            foreach (MetaEntity meta in _meta.GetEntities())
            foreach (GameEntity game in _gameEntities)
            {
                meta.multiplayer.Value.CreateRoom();
            }
        }
    }
}