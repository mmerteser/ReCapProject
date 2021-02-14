using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class IMBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public IMBrandDal()
        {
            _brands = new List<Brand>
            {
            //    new Brand{BrandId=1,BrandDesc="Opel"},
            //    new Brand{BrandId=2,BrandDesc="Renault"},
            //    new Brand{BrandId=3,BrandDesc="Peugeot"},
            //    new Brand{BrandId=4,BrandDesc="Fiat"},
            //    new Brand{BrandId=5,BrandDesc="Volkswagen"},
            //    new Brand{BrandId=6,BrandDesc="Toyota"},
            };
        }

        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
