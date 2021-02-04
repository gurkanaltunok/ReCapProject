using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("-----Bütün Arabalar-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, Color Id: {2}, Model Year: {3}, Daily Price = {4} TL, Description: {5}",car.CarId,car.BrandId,car.ColorId,car.ModelYear,car.DailyPrice,car.ModelYear,car.DailyPrice,car.Description);
            }

            Console.WriteLine("-----Siyah Arabalar-----");
            foreach (var car in carManager.GetByColor(14))
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, Color Id: {2}, Model Year: {3}, Daily Price = {4} TL, Description: {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("-----Volvo Marka Arabalar-----");
            foreach (var car in carManager.GetByBrand(41))
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, Color Id: {2}, Model Year: {3}, Daily Price = {4} TL, Description: {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("-----Günlük Ücreti 200-300 TL Arası Arabalar-----");
            foreach (var car in carManager.GetByDailyPrice(200,300))
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, Color Id: {2}, Model Year: {3}, Daily Price = {4} TL, Description: {5}", car.CarId, car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.ModelYear, car.DailyPrice, car.Description);
            }










        }
    }
}
