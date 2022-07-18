namespace Code.Systems.Input
{
    public class InputSystems : Feature
    {
        public InputSystems(Contexts contexts) : base(nameof(InputSystems))
        {
            Add(new EmitInputSystem(contexts.input));
        }
    }
}