using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities.Concrete;
using System;

namespace ReCapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var item in rentalManager.GetAllRentalDetails().Data)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.RentDate);
            }

            rentalManager.Add(new Rental
            {
                CustomerId = 1,
                CarId = 1,
                RentDate = DateTime.Now
            });

            var message = rentalManager.Add(new Rental
            {
                CustomerId = 1,
                CarId = 1,
                RentDate = DateTime.Now
            }).Message;

            Console.WriteLine(message);
        }
    }
}
