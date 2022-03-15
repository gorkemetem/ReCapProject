using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        List<Car> _cars;

        public EfCarDal()
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
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(carToUpdate);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cars.Where(c => c.ColorId == id).ToList();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.Description = entity.Description;
        }
    }
}
