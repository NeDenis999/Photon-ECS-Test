using System;
using Entitas;
using UnityEngine;

namespace Code.ViewListeners
{
    public class PositionListener : MonoBehaviour, IPositionListener, IEventListener
    {
        private GameEntity _entity;
        private Rigidbody2D _rigidbody2D;
       // private Vector2 _previousPosition;
        
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            //_previousPosition = transform.position;
        }

        private void Update()
        {
            /*if (_previousPosition != _entity.position.Value)
            {
                var currentPosition = transform.position;
                
                OnPosition(_entity, _entity.position.Value);
                _previousPosition = currentPosition;
            }*/
        }

        public void OnPosition(GameEntity entity, Vector2 value)
        {
            if (_rigidbody2D)
                _rigidbody2D.position = value;
            else
                transform.position = value;
        }

        public void RegisterListeners(IEntity entity)
        {
            _entity = (GameEntity) entity;
            _entity.AddPositionListener(this);
            
            if (_entity.hasPosition)
                OnPosition(_entity, transform.position);
        }

        public void UnRegisterListeners(IEntity entity)
        {
            _entity.RemovePositionListener(this);
        }
        
         private void LateUpdate()
         {
             if (_entity == null)
                 return;
                    
             if (_rigidbody2D != null)
                 _entity.ReplacePosition(_rigidbody2D.position);
             else
                 _entity.ReplacePosition(transform.position);
         }
    }
}