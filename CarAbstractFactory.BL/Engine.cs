using System;

namespace CarAbstractFactory.BL
{
    public class Engine : IEngine
    {
        public int MaxSpeed { get; }
        public string Name { get; }

        public Engine(string name, int maxSpeed)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Название двигателя не может быть пустым.");
            if (maxSpeed <= 0)
                throw new ArgumentException("Максимальная скорость двигателя не может быть меньше либо равна нулю.", 
                                            nameof(maxSpeed));

            Name = name;
            MaxSpeed = maxSpeed;
        }
    }
}