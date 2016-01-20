namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Separate the construction of a complex object from its representation, allowing the same construction process to create various representations.
    /// </summary>
    public class BuilderPattern
    {
        public static void Test()
        {
            ICarBuilder carBuilder = new BMWCarBuilder();
            var car = carBuilder.MakeCar(CarType.Family);
            carBuilder = new MercCarBuilder();
            car = carBuilder.MakeCar(CarType.Sport);
        }
    }

    public interface ICarBuilder
    {
        Car MakeCar(CarType type);
    }

    public class BMWCarBuilder : ICarBuilder
    {
        public Car MakeCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.Family:
                    return new FamilyCar();
                case CarType.Sport:
                    return new SportsCar();
                default:
                    return new Car();
            }
        }
    }

    public class MercCarBuilder : ICarBuilder
    {
        public Car MakeCar(CarType carType)
        {
            switch (carType)
            {
                case CarType.Family:
                    return new MercFamilyCar();
                case CarType.Sport:
                    return new MercSportsCar();
                default:
                    return new Car();
            }
        }
    }

    public enum CarType
    {
        Family,
        Sport
    }


    public class Car{}

    public class FamilyCar : Car{}

    public class SportsCar : Car{}

    public class MercFamilyCar : Car { }

    public class MercSportsCar : Car { }
}