using System;
using CanWeTrade.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanWeTrade.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; set; }
        Car getObjectCar(int carId);
    }
}
