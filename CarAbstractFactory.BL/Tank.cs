using System;

namespace CarAbstractFactory.BL
{
    public class Tank : ITank
    {
        public int Capacity { get; }
        public int Value { get; private set; }
        public string Name { get; }

        public Tank(string name, int capacity)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name), "Название топливного бака не может быть пустым.");
            if (capacity <= 0)
                throw new ArgumentException("Вместимость топливного бака не может быть меньше либо равна нулю.", nameof(capacity));

            Name = name;
            Capacity = capacity;
            Value = Capacity;
        }

        public int Spend(int value)
        {
            if(Value >= value)
                Value -= value;
            else
            {
                value = Value;
                Value = 0;
            }
            return value;
        }
    }
}