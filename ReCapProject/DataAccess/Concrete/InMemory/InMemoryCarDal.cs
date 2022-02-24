using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1, ColorId = 1 , ModelYear =2000, DailyPrice=65000 },
                new Car{Id = 2,BrandId = 2, ColorId = 2 , ModelYear =2001, DailyPrice=23441 },
                new Car{Id = 3,BrandId = 3, ColorId = 3 , ModelYear =2002, DailyPrice=34543 },
                new Car{Id = 4,BrandId = 4, ColorId = 4 , ModelYear =2004, DailyPrice=87879 },
                new Car{Id = 5,BrandId = 5, ColorId = 5 , ModelYear =2005, DailyPrice=89898 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetALL()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
         }
    }
}
