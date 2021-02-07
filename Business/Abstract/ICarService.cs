using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetByBrand(int brandId);
        List<Car> GetByColor(int colorId);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<CarDetailDto> GetCarDetails();
    }
}
