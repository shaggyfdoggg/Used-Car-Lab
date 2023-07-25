using System;

namespace Used_Car_Lot
{
	internal class Car
	{
		//properties
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public decimal Price { get; set; }

		//constructor
		public Car ()
		{
			Make = "Ford";
			Model = "Taurus";
			Year = 2002;
			Price = 2500.00m;
		}
		public Car(string _make, string _model, int _year, decimal _price)
		{
			Make = _make;
			Model = _model;
			Year = _year;
			Price = _price;

		}
        public override string ToString()
        {
            return $"Make{Make}, Model{Model},Year{Year},Price{Price}";

        }
    }
}

