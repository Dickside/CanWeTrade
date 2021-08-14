﻿using CanWeTrade.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanWeTrade.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string currCategory { get; set; }
    }
}
