using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilforhandler
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _make;
        private string _regNumber;
        private double _kmDriven;
        private int _price;

        public Car(string brand, string model, int make, string regNumber, double kmDriven, int price)
        {
            _brand = brand;
            _model = model;
            _make = make;
            _regNumber = regNumber;
            _kmDriven = kmDriven;
            _price = price;
        }

        public string GetBrand()
        {
            return _brand;
        }

        public int GetMake()
        {
            return _make;
        }

        public int GetPrice()
        {
            return _price;
        }


    }
}
