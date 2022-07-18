using Entitas;
using Photon.Pun;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Code.Systems.Photon
{
    public class SpawnHeroSystem : IInitializeSystem
    {
        private IGroup<GameEntity> _game;
        
        public SpawnHeroSystem(GameContext game)
        {
            _game = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Spawner, GameMatcher.SpawnPoints, GameMatcher.Prefab)
                .NoneOf(GameMatcher.SpawnerCreatedHero));
        }
        
        public void Initialize()
        {
            //Debug.Log("Initialize");
            
            foreach (var spawner in _game)
            {
                break;
                Debug.Log("spawn");

                var hero = spawner.prefab.Value;
                var spawnPoints = spawner.spawnPoints.Value;
                var spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

                PhotonNetwork.Instantiate(nameof(hero), spawnPoint, Quaternion.identity);
                spawner.isSpawnerCreatedHero = true;
            }
        }
    }
}