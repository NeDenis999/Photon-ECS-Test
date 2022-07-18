using Code.Infrastructure;
using Photon.Pun;
using UnityEngine;
using static Code.Expansion.VectorExpansion;

namespace Code.Behaviour
{
    public class SpawnerBehaviour : EntityBehaviour
    {
        public Transform[] SpawnPoints;
        public HeroBehaviour Hero;

        protected override void OnStart()
        {
            base.OnStart();
            Entity.isSpawner = true;
            Entity.AddSpawnPoints(SpawnPoints.ToVector2());
            Entity.AddPrefab(Hero.gameObject);
        }
    }
}