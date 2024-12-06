using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    internal class Person(string _name, int _money)
    {
        private string _name;
        private List<Car> carList = [];
        private int _money = 0;

        public void Purchase(Car car) //vet ikke om denne er ferdig eller gir mening?
        {
            carList.Add(car);
        }
    }
}
