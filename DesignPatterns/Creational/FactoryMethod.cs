using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FM
{
    /// <summary>
    /// Factory Method
    /// Define an interface for creating a single object, but let subclasses decide which class to instantiate.
    /// Factory Method lets a class defer instantiation to subclasses.
    /// </summary>

    public class FactoryMethod
    {
        public static void Test()
        {
            ICarFactory carFactory = new CarFactory();
            var car = carFactory.MakeCar();
            carFactory = new SportCarFactory();
            car = carFactory.MakeCar();
        }
    }

    public interface ICarFactory
    {
        Car MakeCar();
    }

    public class CarFactory : ICarFactory
    {
        public Car MakeCar()
        {
            return new Car();
        }
    }

    public class Car
    {
         
    }

    public class SportCarFactory : ICarFactory
    {
        public Car MakeCar()
        {
            return new SportCar();
        }
    }

    public class SportCar : Car
    {
        
    }
}
