using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=1000, ModelYear=1998, Description= "Deneme" },
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=2000, ModelYear=1999, Description= "Deneme1" },
                new Car{Id=3, BrandId=2, ColorId=3, DailyPrice=3000, ModelYear=2000, Description= "Deneme2" },
                new Car{Id=4, BrandId=2, ColorId=3, DailyPrice=4000, ModelYear=2005, Description= "Deneme3" },
                new Car{Id=5, BrandId=2, ColorId=4, DailyPrice=5000, ModelYear=2008, Description= "Deneme4" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToUpdate);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.BrandId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
