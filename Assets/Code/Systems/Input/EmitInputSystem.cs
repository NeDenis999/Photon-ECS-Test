using Entitas;

namespace Code.Systems.Input
{
    public class EmitInputSystem : IInitializeSystem, IExecuteSystem
    {
        private IGroup<InputEntity> _input;

        public EmitInputSystem(InputContext input)
        {
            _input = input.GetGroup(InputMatcher.Horizontal);
        }

        public void Initialize()
        {
            if (_input.GetEntities().Length > 0)
                return;
            
            var entity = Contexts.sharedInstance.input.CreateEntity();
            entity.AddHorizontal(0);
        }

        public void Execute()
        {
            foreach (var input in _input)
            {
                input.ReplaceHorizontal(UnityEngine.Input.GetAxis("Horizontal"));
            }
        }
    }
}