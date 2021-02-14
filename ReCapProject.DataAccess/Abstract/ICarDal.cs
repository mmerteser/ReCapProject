﻿using ReCapProject.Core.DataAccess;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails();
    }
}
