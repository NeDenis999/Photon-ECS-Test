using Code.Infrastructure;
using UnityEngine;

namespace Code.Behaviour
{
    public class HeroBehaviour : EntityBehaviour
    {
        [SerializeField] 
        private Rigidbody2D _rigidbody2D;
        
        protected override void OnStart()
        {
            Entity.isHero = true;
            Entity.AddSpeed(2);
            Entity.AddRigidbody2D(_rigidbody2D);
        }
    }
}