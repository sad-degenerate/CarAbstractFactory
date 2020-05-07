namespace CarAbstractFactory.BL
{
    public interface ICarFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
        ITank CreateTank();
    }
}