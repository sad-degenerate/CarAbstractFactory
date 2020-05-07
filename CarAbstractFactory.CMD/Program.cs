using CarAbstractFactory.BL;
using System;

namespace CarAbstractFactory.CMD
{
    class Program
    {
        private static ICarFactory factory;

        static void Main(string[] args)
        {
            Console.WriteLine("Приложение запущено.");

            factory = new CheapCarFactory();
            CreateAndRun(factory, 50);

            factory = new ExpensiveCarFactory();
            CreateAndRun(factory, 70);
        }

        static void CreateAndRun(ICarFactory factory, int speed)
        {
            var car = new Car(factory.CreateBody(), factory.CreateEngine(), factory.CreateTank());

            // Ну дальше нужны какие-нибудь формулы пор расчёту скорости в зависимости от веса
            // и прочих факторов, расход топлива... но я по простому сделал.

            Console.WriteLine($"{car.Serial} начала движение.");

            if (speed >= car.Engine.MaxSpeed || speed <= 0)
                speed = car.Engine.MaxSpeed;

            // Просто переменная для простого расчета.
            var percent = 0.01;

            double path = 0.0;
            double actualSpeed = speed - (car.Body.Weight * percent);

            while (car.Tank.Value != 0)
                path += actualSpeed * car.Tank.Spend(1);

            Console.WriteLine($"Всего пройдено: {path}.");
            Console.WriteLine($"Потрачено топлива: {car.Tank.Capacity}\n\n");

            // Да-да, я знаю, что это не совсем так работает, но это просто простая реализация
            // логики движения, её можно заменить на более сложную с довольно минимальным
            // добавлением / редактированием кода.
        }
    }
}