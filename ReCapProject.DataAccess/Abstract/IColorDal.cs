using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface IColorDal
    {
        List<Color> GetById(int Id);
        List<Color> GetAll();
        void Add(Color entity);
        Color Update(Color entity);
        void Delete(Color entity);
    }
}
