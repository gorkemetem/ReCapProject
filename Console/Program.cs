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
            //CarTest();

            //BrandTest();

            //ColorTest();

            CarManager carmanager = new CarManager(new EfCarDal());
            foreach (var car in carmanager.GetCarDetails())
            {
                System.Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                System.Console.WriteLine(color.Name + " / " + color.Id);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                System.Console.WriteLine(brand.Name + " / " + brand.Id);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Name + " / " + car.Description);
            }
            System.Console.WriteLine("************************************");
            foreach (var car in carManager.GetById(1))
            {
                System.Console.WriteLine(car.Name);
            }
            System.Console.WriteLine("************************************");
            Car newCar = new Car{ Name = "yeni araba 3", DailyPrice = 15, Description="deneme", BrandId=3, ColorId=2, Id=1, ModelYear=2021 };;
            carManager.Add(newCar);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Name);
            }
            System.Console.WriteLine("************************************");
            carManager.Delete(newCar);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Name);
            }
            System.Console.WriteLine("************************************");
            carManager.Update(newCar);
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Name);
            }
        }
    }
}
