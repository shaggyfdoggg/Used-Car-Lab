using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot
{
    internal class UsedCar:Car
    {
        public double Mileage { get; set; }

        public bool Used { get; set; }

        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage, bool _used) : base(_make, _model, _year, _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
            Mileage = _mileage;
            Used = _used;

        }

        public override string ToString()
        {
            return base.ToString() + Mileage + Used;
        }


    }
}
