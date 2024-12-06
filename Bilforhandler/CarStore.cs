using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    internal class CarStore
    {
        List<Car> _carStoreList = [];
        public string _carStoreName { get; private set; }

        public CarStore(string carStoreName)
        {
            _carStoreName = carStoreName;
        }

        public void AddCar(Car car)
        {
            _carStoreList.Add(car);
        }

        public bool SellCar(Car car)
        {
            if (_carStoreList.Contains(car))
            {
                _carStoreList.Remove(car);
                return true;
            }
            else
            {
                return false;
            }

        }






        //{
        //    _carStoreList.Remove(car);

        //}
    }
}
