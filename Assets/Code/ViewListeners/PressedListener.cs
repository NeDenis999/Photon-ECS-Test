using Entitas;
using UnityEngine;
using UnityEngine.UI;

namespace Code.ViewListeners
{
    public class PressedListener : MonoBehaviour, IPressedListener, IEventListener
    {
        [SerializeField] 
        private Button _button;
        
        private GameEntity _entity;
        
        public void RegisterListeners(IEntity entity)
        {
            _entity = (GameEntity) entity;
            _entity.AddPressedListener(this);
            
            _button.onClick.AddListener(Pressed);
        }

        public void UnRegisterListeners(IEntity entity)
        {
            _entity.RemovePressedListener(this);
            
            _button.onClick.RemoveListener(Pressed);
        }

        public void OnPressed(GameEntity entity)
        {

        }

        private void Pressed()
        {
            _entity.isPressed = true;
        }
    }
}