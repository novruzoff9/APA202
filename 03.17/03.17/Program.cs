using _03._17;

//Vehicle vehicle1 = new();
////vehicle1.Brand = "a";
//vehicle1._brand = "a";
//Console.WriteLine(vehicle1.Brand);

Vehicle vehicle1 = new("Audi", "RS6", 2015);
vehicle1.StartEngine();
vehicle1.Drive(50);
vehicle1.VehicleInfo();