using Used_Car_Lot;

Console.WriteLine("Welcome to the Used Car Emporium");


List<Car> Inventory = new List<Car>()
{
    new UsedCar("Chevy", "Equinox", 2012, 3000m, 112000, true),
    new Car("Chevy", "Camaro", 2023, 35000m),
    new UsedCar("Honda", "Civic", 2016, 15500m, 50000, true),
    new UsedCar("Subaru", "Forester", 2016, 18000m, 70000, true),
    new UsedCar("Hyundai", "Santa Fe", 2020, 37000m, 25000, true),
    new UsedCar("Ford", "Mustang", 2017, 19975.00m, 80000, true),
    new UsedCar("Toyota", "Corolla", 2000, 4000m, 99000, true),
    new UsedCar("Honda", "Fit", 2014, 15000m, 70000, true)

};

foreach(UsedCar c in Inventory)
{
    c.ToString();
}