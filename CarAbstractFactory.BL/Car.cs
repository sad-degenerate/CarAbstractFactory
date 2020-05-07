using System;

namespace CarAbstractFactory.BL
{
    public class Car
    {
        public IBody Body { get; }
        public IEngine Engine { get; }
        public ITank Tank { get; }
        public string Serial { get; }

        public Car(IBody body, IEngine engine, ITank tank)
        {
            Body = body ?? throw new ArgumentNullException(nameof(body), "Корпус машины не может быть равен null.");
            Engine = engine ?? throw new ArgumentNullException(nameof(engine), "Двигатель машины не может быть равен null.");
            Tank = tank ?? throw new ArgumentNullException(nameof(tank), "Корпус машины не может быть равен null.");

            Serial = Guid.NewGuid().ToString();
        }
    }
}