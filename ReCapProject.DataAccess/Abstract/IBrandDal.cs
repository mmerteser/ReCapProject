using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface IBrandDal
    {
        List<Brand> GetById(int Id);
        List<Brand> GetAll();
        void Add(Brand entity);
        Brand Update(Brand entity);
        void Delete(Brand entity);
    }
}
