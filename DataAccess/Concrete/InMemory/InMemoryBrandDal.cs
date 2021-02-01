using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
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
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public void GetById(int brandId)
        {
            _brands.Find(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
