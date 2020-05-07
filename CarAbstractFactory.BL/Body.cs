using System;

namespace CarAbstractFactory.BL
{
    public class Body : IBody
    {
        public int Weight { get; }
        public string Name { get; }

        public Body(string name, int weight)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Название корпуса не может быть пустым.");
            if (weight <= 0)
                throw new ArgumentException("Вес корпуса не может быть меньше либо равен нулю.", nameof(weight));

            Name = name;
            Weight = weight;
        }
    }
}