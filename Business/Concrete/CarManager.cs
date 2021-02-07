using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                Console.WriteLine("Arabanın Açıklamasını Kontrol Ediniz");
            }
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Arabanın Günlük Ücretini Kontrol Ediniz");
            }

            else
            {
                _carDal.Add(car);
            }
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetByColor(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
