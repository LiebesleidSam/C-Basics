using Classes;

Vehicle myCar = new Vehicle();

myCar.TypeOfVehicle = VehicleType.Car;
myCar.Make = "Toyota";
myCar.Model = "Prius";
myCar.Mileage = 50000;
myCar.Color = "Silver";

myCar.TurnOn();
Console.WriteLine(myCar.IsRunning);

myCar.TurnOff();
Console.WriteLine(myCar.IsRunning);

myCar.TurnOnHazards();
Console.WriteLine(myCar.LeftIndicator.IsFlashing);

myCar.ClearIndicators();
Console.WriteLine(myCar.RightIndicator.IsFlashing);