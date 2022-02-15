using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car {Id = 6, BrandId = 3, ColorId = 1, DailyPrice = 1500, Description = "Yeni araba", ModelYear = 2022 };
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
            System.Console.WriteLine("**********************************");

            foreach (var car in carManager.GetById(2))
            {
                System.Console.WriteLine(car.Description);
            }
            System.Console.WriteLine("**********************************");

            carManager.Add(car1);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
            System.Console.WriteLine("**********************************");

            car1.Description = "Update";
            carManager.Update(car1);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
            System.Console.WriteLine("**********************************");

            carManager.Delete(car1);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }
            System.Console.WriteLine("**********************************");



        }
    }
}
