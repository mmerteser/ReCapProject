using ReCapProject.Core.DataAccess;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        public List<RentalDetailsDto> GetRentalDetails(Expression<Func<Rental,bool>> filter = null);
    }
}
