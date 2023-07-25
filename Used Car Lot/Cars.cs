﻿using System;

namespace Used_Car_Lot
{
	public class Cars
	{
		//properties
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public decimal Price { get; set; }

		//constructor
		public Cars ()
		{
			Make = "Ford";
			Model = "Taurus";
			Year = 2002;
			Price = 2500.00m;
		}
		public Cars(string _make, string _model, int _year, decimal _price)
		{
			Make = _make;
			Model = _model;
			Year = _year;
			Price = _price;

		}
	}
}

