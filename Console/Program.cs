using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car {Id = 6, BrandId = 3, ColorId = 1, DailyPrice = 5, Description = "Yeni araba", ModelYear = 2022 };
            Car car2 = new Car { Id = 7, BrandId = 3, ColorId = 2, DailyPrice = 15, Description = "Yeni araba2", ModelYear = 2022 };
            Car car3 = new Car { Id = 8, BrandId = 4, ColorId = 3, DailyPrice = -5, Description = "Yeni araba3", ModelYear = 2022 };
            CarManager carManager = new CarManager(new EfCarDal());

          carManager.Add(car3);
            foreach (var entity in carManager.GetAll())
            {
                System.Console.WriteLine(entity.Description);
            }

    
        }
    }
}
