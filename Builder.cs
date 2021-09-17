using System;

namespace Patterns
{
    public class Builder
    {
        public void Run()
        {
            var builder = new CarBuilder();
            BuildBlueToyota(builder);

            var car = builder.Build();
            Console.WriteLine(car);
        }

        public void BuildBlueToyota(ICarBuilder builder)
        {
            builder
                .SetMake("Toyota")
                .SetColor("Blue")
                .SetManicfactureDate("Today");
        }
    }


    public class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string ManifactureDate { get; set; }

        public override string ToString()
        {
            return $"{Make} / {Color} / {ManifactureDate}";
        }
    }

    public interface ICarBuilder
    {
        public ICarBuilder SetMake(string make);
        public ICarBuilder SetColor(string color);
        public ICarBuilder SetManicfactureDate(string date);
    }

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ICarBuilder SetMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public ICarBuilder SetManicfactureDate(string date)
        {
            _car.ManifactureDate = date;
            return this;
        }

        public Car Build() => _car;
    }
}
