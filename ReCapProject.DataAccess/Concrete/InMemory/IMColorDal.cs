using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class IMColorDal : IColorDal
    {
        List<Color> _colors;
        public IMColorDal()
        {
            _colors = new List<Color>
            {
                new Color{ColorId=1,ColorName="Beyaz"},
                new Color{ColorId=2,ColorName="Siyah"},
                new Color{ColorId=3,ColorName="Gri"},
                new Color{ColorId=4,ColorName="Metalik Beyaz"},
                new Color{ColorId=5,ColorName="Metalik Siyah"},
                new Color{ColorId=6,ColorName="Metalik Gri"},
            };
        }

        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
