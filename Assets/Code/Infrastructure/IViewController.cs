using Entitas;

namespace Code.Infrastructure
{
    public interface IViewController
    {
        IViewController InitializeView(GameContext @in, IEntity @with);
        void Destroy();
        GameEntity Entity { get; }
    }
}