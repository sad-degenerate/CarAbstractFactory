namespace CarAbstractFactory.BL
{
    public class CheapCarFactory : ICarFactory
    {
        public IBody CreateBody()
        {
            return new Body("Cheap Body", 200);
        }

        public IEngine CreateEngine()
        {
            return new Engine("Cheap Engine", 110);
        }

        public ITank CreateTank()
        {
            return new Tank("Cheap Tank", 250);
        }
    }
}