namespace CarAbstractFactory.BL
{
    public interface IEngine : IComponent
    {
        int MaxSpeed { get; }
    }
}