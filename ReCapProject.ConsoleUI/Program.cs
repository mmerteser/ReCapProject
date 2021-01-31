using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities.Concrete;
using System;

namespace ReCapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new IMCarDal());

            foreach (var item in carManager.GetById(3))
            {
                Console.WriteLine($"{item.Description} - {item.BrandId} - {item.ColorId} - {item.DailyPrice}");
            }

            carManager.Add(new Car { CarId = 7, ColorId = 2, BrandId = 5, Description = "Golf", DailyPrice = 600, ModelYear = 2021 });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"{item.Description} - {item.BrandId} - {item.ColorId} - {item.DailyPrice}");
            }

            carManager.Update(new Car { CarId = 7, ColorId = 2, BrandId = 5, Description = "Polo", DailyPrice = 600, ModelYear = 2021 });
            foreach (var item in carManager.GetAll())
            {
                Console.WriteLine($"{item.Description} - {item.BrandId} - {item.ColorId} - {item.DailyPrice}");
            }
        }
    }
}
