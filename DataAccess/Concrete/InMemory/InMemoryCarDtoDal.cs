using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDtoDal : ICarDtoDal
    {
        public List<CarDto> GetAllDto(ICarDal carDal, IBrandDal brandDal, IColorDal colorDal)
        {
            List<Car> cars = carDal.GetAll();
            List<Brand> brands = brandDal.GetAll();
            List<Color> colors = colorDal.GetAll();

            var carDto = from c in cars
                         join b in brands
                         on c.BrandId equals b.BrandId
                         join co in colors
                         on c.ColorId equals co.ColorId
                         orderby c.DailyPrice
                         select new CarDto
                         {
                             CarId = c.CarId,
                             ModelYear = c.ModelYear,
                             BrandName = b.BrandName,
                             ColorName = co.ColorName,
                             DailyPrice = c.DailyPrice,
                             Description = c.Description
                         };

            return carDto.ToList();
        }
    }
}
