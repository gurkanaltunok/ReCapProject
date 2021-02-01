using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        ICarDtoDal _carDtoDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;

        public List<CarDto> GetAllDto()
        {
            return _carDtoDal.GetAllDto(_carDal, _brandDal, _colorDal);
        }

        public CarManager(ICarDal carDal, ICarDtoDal carDtoDal, IBrandDal brandDal, IColorDal colorDal)
        {
            _carDal = carDal;
            _carDtoDal = carDtoDal;
            _brandDal = brandDal;
            _colorDal = colorDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void GetById(int carId)
        {
            _carDal.GetById(carId);
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _carDal.GetByBrand(brandId);
        }

        public List<Car> GetByColor(int colorId)
        {
            return _carDal.GetByBrand(colorId);
        }
    }
}
