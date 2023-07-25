using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Used_Car_Lot
{
    internal class UsedCar:Cars
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

        public void ToStringMileage()
        {
            if (Used == true)
            {
                Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price},: Mileage {Mileage} (Used)");
            } else
            {
                Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}");
            }
        
        }

        

    }
}
