using Entities.Concrete;
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
        void GetById(int carId);
        List<Car> GetByBrand(int brandId);
        List<Car> GetByColor(int colorId);
        List<CarDto> GetAllDto();
    }
}
