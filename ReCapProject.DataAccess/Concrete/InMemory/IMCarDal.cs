using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class IMCarDal : ICarDal
    {
        List<Car> _cars;
        public IMCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,Description="Astra",DailyPrice=400,ModelYear=2021},
                new Car{CarId=2,BrandId=2,ColorId=2,Description="Megane",DailyPrice=500,ModelYear=2021},
                new Car{CarId=3,BrandId=3,ColorId=3,Description="3008",DailyPrice=600,ModelYear=2021},
                new Car{CarId=4,BrandId=4,ColorId=4,Description="Egea",DailyPrice=350,ModelYear=2021},
                new Car{CarId=5,BrandId=5,ColorId=5,Description="Passat",DailyPrice=700,ModelYear=2021},
                new Car{CarId=6,BrandId=6,ColorId=6,Description="Corolla",DailyPrice=500,ModelYear=2021},
            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
