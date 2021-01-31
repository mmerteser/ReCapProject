using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetById(int Id);
        List<Color> GetAll();
        void Add(Color entity);
        Color Update(Color entity);
        void Delete(Color entity);
    }
}
