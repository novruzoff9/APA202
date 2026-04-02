using _04._01.Enums;

namespace _04._01.iNTERFACES;

internal class CargoService : ICargoService
{
    public static Customer[] Customers = [];
    public static Courier[] Couriers = [];
    public static CargoOrrder[] Orrders = [];

    public void AddCourier(Courier newCourier)
    {
        Array.Resize(ref Couriers, Couriers.Length + 1);
        Couriers[Couriers.Length - 1] = newCourier;
    }

    
    public void AddCustomer(Customer newCustomer)
    {
        Array.Resize(ref Customers, Customers.Length + 1);
        Customers[Customers.Length - 1] = newCustomer;
    }

    public void CompleteOrder(int Id)
    {
        CargoOrrder exsistOrder = null;
        foreach (var Order in Orrders)
        {
            if (Order.Id==Id)
            {
                exsistOrder = Order;
            }
        }
        if(exsistOrder != null)
        {
            exsistOrder.UpdateStatus(OrderStatus.Delivered);
            foreach (var courier in Couriers)
            {
                if (courier.Id == exsistOrder.CourierId)
                {
                    courier.IsAvailable = true;
                }

            }
        }
    }

    public void CreateOrder(CargoOrrder newCargo)
    {
        Customer existcustomer = null;
        foreach (var customer in Customers)
        {
            if (customer.Id==newCargo.CustomerId)
            {
                existcustomer = customer;
            }
        }
        if (existcustomer==null)
        {
            Console.WriteLine("iSTIFADECI TAPILMADI");
        }
        Courier existcourier = null;
        foreach (var courier in Couriers)
        {
            if (courier.Id== newCargo.CourierId)
            {
                existcourier = courier;
            }
            
        }
        if ( existcourier==null)
        {
            Console.WriteLine(  "tapilmadi ");
        }
        if (existcourier.IsAvailable)
        {
            existcourier.IsAvailable = false;
            Array.Resize(ref Orrders, Orrders.Length + 1);
            Orrders[Orrders.Length - 1]=newCargo;
        }
    }
}
