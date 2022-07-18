using System;
using System.Security.Cryptography;
using Code.Registers;
using Code.ViewListeners;
using Entitas;
using Photon.Pun;
using UnityEngine;

namespace Code.Infrastructure
{
    public class EntityBehaviour : MonoBehaviour
    {
        private GameEntity _entity;

        public GameEntity Entity => _entity;
        
        private void Awake()
        {
            _entity = Contexts.sharedInstance.game.CreateEntity();
            RegisterListeners(_entity);
            RegisterViewListeners(_entity);
            RegisterPosition();
            
            OnAwake();
        }

        private void Start()
        {
            OnStart();
        }

        private void Update()
        {
            OnUpdate();
        }

        private void OnAwake()
        {
            
        }
        
        protected virtual void OnStart()
        {
            
        }

        private void OnUpdate()
        {
            
        }

        private void OnDestroy()
        {
            Destroy(gameObject);
            _entity.Destroy();
        }

        private void RegisterListeners(IEntity with)
        {
            foreach (IEventListener listener in GetComponents<IEventListener>())
                listener.RegisterListeners(with);
        }
        
        private void RegisterViewListeners(GameEntity with)
        {
            foreach (IViewComponentRegistrator listener in GetComponents<IViewComponentRegistrator>())
                listener.Register(with);
        }

        private void RegisterPosition()
        {
            _entity.AddPosition(transform.position);
        }
    }
}