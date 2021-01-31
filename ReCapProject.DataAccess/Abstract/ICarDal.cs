using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int Id);
        List<Car> GetAll();
        void Add(Car entity);
        Car Update(Car entity);
        void Delete(Car entity);
    }
}
