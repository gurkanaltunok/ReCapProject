using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("===================== Liste =====================");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id : {0}, Brand Id : {1}, ColorId : {2}, Model Year : {3}, Daily Price : {4}, Description : {5}", car.CarId, car.BrandId, car.ColorId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Car car1 = new Car()
            {
                CarId = 8,
                BrandId = 1,
                ColorId = 1,
                ModelYear = 2014,
                DailyPrice = 620,
                Description = "Sedan"
            };
            carManager.Add(car1);

            carManager.Delete(new Car() { CarId = 1 });

            Car car2 = new Car()
            {
                CarId = 3,
                BrandId = 5,
                ColorId = 4,
                ModelYear = 2003,
                DailyPrice = 140,
                Description = "SUV"
            };

            carManager.Update(car2);

            Console.WriteLine("===================== Güncel Liste =====================");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id : {0}, Brand Id : {1}, ColorId : {2}, Model Year : {3}, Daily Price : {4}, Description : {5}", car.CarId, car.BrandId, car.ColorId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("===================== Mercedes - Benz Marka Arabalar =====================");

            foreach (var car in carManager.GetByBrand(1))
            {
                Console.WriteLine("Car Id : {0}, Brand Id : {1}, ColorId : {2}, Model Year : {3}, Daily Price : {4}, Description : {5}", car.CarId, car.BrandId, car.ColorId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("===================== Siyah Arabalar =====================");

            foreach (var car in carManager.GetByColor(2))
            {
                Console.WriteLine("Car Id : {0}, Brand Id : {1}, ColorId : {2}, Model Year : {3}, Daily Price : {4}, Description : {5}", car.CarId, car.BrandId, car.ColorId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
        }
    }
}
