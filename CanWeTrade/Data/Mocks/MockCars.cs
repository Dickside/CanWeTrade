using CanWeTrade.Data.Interfaces;
using CanWeTrade.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanWeTrade.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car {name = "Tesla", shortDesc="", longDesc="", img="", price=45000, isFavorite= true, avaliable=true, Category = _categoryCars.AllCategories.First()}
                };


            }
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
