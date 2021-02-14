using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IRentalService
    {
        public IDataResult<List<Rental>> GetAll();
        public IDataResult<List<RentalDetailsDto>> GetAllRentalDetails();
        public IDataResult<List<RentalDetailsDto>> GetByIdRentalDetail(int rentalId);
        public IResult Add(Rental rental);
        public IResult Update(Rental rental);
        public IResult Delete(Rental rental);
    }
}
