namespace DesignPatterns.Creational.AF
{
    /// <summary>
    /// Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    /// </summary>
    public class AbstractFactory
    {
        public static void Test()
        {
            ICarFactory carFactory = new MercedesFactory();
            var familyCar = carFactory.CreateFamilyCar();
            var sportsCar = carFactory.CreateSportsCar();
        }
    }

    public interface ICarFactory
    {
        SportsCar CreateSportsCar();
        FamilyCar CreateFamilyCar();
    }

    public abstract class CarFactory : ICarFactory
    {
        public abstract SportsCar CreateSportsCar();

        public abstract FamilyCar CreateFamilyCar();
    }

    public class MercedesFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }

        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }
    }

    public class Car
    {
        
    }

    public class FamilyCar : Car
    {
    }

    public class SportsCar : Car
    {
    }

    public class MercedesSportsCar : SportsCar
    {
    }

    public class MercedesFamilyCar : FamilyCar
    {
    }
}