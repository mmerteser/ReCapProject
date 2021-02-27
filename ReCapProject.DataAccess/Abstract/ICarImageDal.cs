using ReCapProject.Core.DataAccess;
using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarImageDal : IEntityRepository<CarImage>
    {
    }
}
