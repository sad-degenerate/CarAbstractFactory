namespace CarAbstractFactory.BL
{
    public interface ITank : IComponent
    {
        int Capacity { get; }
        int Value { get; }

        int Spend(int value);
    }
}