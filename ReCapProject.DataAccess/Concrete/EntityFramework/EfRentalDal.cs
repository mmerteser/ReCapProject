using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EFEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from rentals in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join cars in context.Cars on rentals.CarId equals cars.CarId
                             join colors in context.Colors on cars.ColorId equals colors.ColorId
                             join brands in context.Brands on cars.BrandId equals brands.BrandId
                             join customers in context.Customers on rentals.CustomerId equals customers.CustomerId
                             join users in context.Users on customers.UserId equals users.UserId
                             select new RentalDetailsDto
                             {
                                 RentalId = rentals.RentalId,
                                 FirstName = users.FirstName,
                                 LastName = users.LastName,
                                 CompanyName = customers.CompanyName,
                                 CarName = cars.Description,
                                 ColorName = colors.ColorName,
                                 BrandName = brands.BrandName,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
