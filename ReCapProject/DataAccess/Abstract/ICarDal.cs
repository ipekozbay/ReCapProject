using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int Id);
        List<Car> GetALL();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
