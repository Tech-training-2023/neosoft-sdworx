using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison
{
    public class CarOperations
    {
        public Car[] GetAllCars()
        {
            Car[] cars = new Car[]
            {
            new Car("BMW", 2016),
            new Car("Dodge", 2020),
            new Car("Honda", 2021),
            new Car("Land Rover", 2019),
            new Car("Mini Cooper", 1932),
            new Car("Buick", 1932)
            };
            return cars;
        }
    }
}
