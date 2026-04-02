using _04._01;
using _04._01.iNTERFACES;

Customer customer1 = new Customer() { Name = "Elvin", City = "Baku" };
Customer customer2 = new Customer() { Name = "Elnur", City = "Baku" };

Courier courier1 = new Courier() { Name = "Ali", IsAvailable = true };
Courier courier2 = new Courier() { Name = "Veli", IsAvailable = true };

CargoOrrder order1 = new CargoOrrder() { CustomerId = 2, CourierId = 5 };

CargoService cargoService = new CargoService();
cargoService.AddCustomer(customer1);
cargoService.AddCustomer(customer2);

cargoService.AddCourier(courier1);
cargoService.AddCourier(courier2);

cargoService.CreateOrder(order1);

