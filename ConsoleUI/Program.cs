using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",car.CarId,car.BrandName,car.ColorName,car.ModelYear,car.DailyPrice,car.Description);
            }

            Console.WriteLine("Bütün Arabalar :");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("Siyah Arabalar :");
            foreach (var car in carManager.GetByColor(14))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("Volvo Marka Arabalar :");
            foreach (var car in carManager.GetByBrand(41))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            Console.WriteLine("Günlük Ücreti 200 - 300 TL Arası Olan Arabalar :");
            foreach (var car in carManager.GetByDailyPrice(200,300))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Description}");
            }

            carManager.Add(new Car { CarId = 14, BrandId = 10, ColorId = 3, DailyPrice = -230, Description = "" });

            











        }
    }
}
