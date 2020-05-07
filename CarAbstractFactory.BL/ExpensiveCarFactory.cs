namespace CarAbstractFactory.BL
{
    public class ExpensiveCarFactory : ICarFactory
    {
        public IBody CreateBody()
        {
            return new Body("Expensive Body", 145);
        }

        public IEngine CreateEngine()
        {
            return new Engine("Expensive Engine", 150);
        }

        public ITank CreateTank()
        {
            return new Tank("Expensive Tank", 175);
        }
    }
}