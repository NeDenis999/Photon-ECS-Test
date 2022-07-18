using Entitas;

namespace Code.ViewListeners
{
    public interface IEventListener
    {
        void RegisterListeners(IEntity entity);
        void UnRegisterListeners(IEntity entity);
    }
}