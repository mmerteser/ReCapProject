using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface IUserService
    {
        public IDataResult<List<User>> GetAll();
        public IResult Add(User user);
        public IResult Update(User user);
        public IResult Delete(User user);
    }
}
