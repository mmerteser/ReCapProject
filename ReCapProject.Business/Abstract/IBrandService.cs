using ReCapProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetById(int Id);
        List<Brand> GetAll();
        void Add(Brand entity);
        Brand Update(Brand entity);
        void Delete(Brand entity);
    }
}
