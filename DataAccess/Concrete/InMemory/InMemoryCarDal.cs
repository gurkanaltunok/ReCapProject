using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;

        public InMemoryCarDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId = 1, BrandName = "Mercedes - Benz"},
                new Brand{BrandId = 2, BrandName = "Audi"},
                new Brand{BrandId = 3, BrandName = "Porsche"},
                new Brand{BrandId = 4, BrandName = "Tesla"},
                new Brand{BrandId = 5, BrandName = "Hyundai"},
                new Brand{BrandId = 6, BrandName = "Toyota"},
                new Brand{BrandId = 7, BrandName = "BMW"}
            };

            _colors = new List<Color>
            {
                new Color{ColorId = 1, ColorName = "Beyaz"},
                new Color{ColorId = 2, ColorName = "Siyah"},
                new Color{ColorId = 3, ColorName = "Mavi"},
                new Color{ColorId = 4, ColorName = "Kırmızı"},
                new Color{ColorId = 5, ColorName = "Kahverengi"},
                new Color{ColorId = 6, ColorName = "Gri"}

            };

            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId =1, ColorId = 2, ModelYear = 2017, DailyPrice = 400, Description= "Sedan"},
                new Car{CarId = 2, BrandId =2, ColorId = 2, ModelYear = 2021, DailyPrice = 900, Description= "SUV"},
                new Car{CarId = 3, BrandId =2, ColorId = 3, ModelYear = 2015, DailyPrice = 450, Description= "Sedan"},
                new Car{CarId = 4, BrandId =4, ColorId = 1, ModelYear = 2017, DailyPrice = 600, Description= "Sedan"},
                new Car{CarId = 5, BrandId =5, ColorId = 6, ModelYear = 2009, DailyPrice = 200, Description= "Sedan"},
                new Car{CarId = 6, BrandId =3, ColorId = 6, ModelYear = 2014, DailyPrice = 750, Description= "Coupe"},
                new Car{CarId = 7, BrandId =7, ColorId = 4, ModelYear = 2017, DailyPrice = 550, Description= "Coupe"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByColor(int colorId)
        {
            return _cars.Where(c => c.CarId == colorId).ToList();
        }

        public void GetById(int carId)
        {
            _cars.Find(c => c.CarId == c.CarId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
