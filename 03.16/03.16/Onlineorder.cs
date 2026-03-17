namespace _03._16;

internal class OnlineOrder : Order
{
    public double Distance;
    public OnlineOrder(int id, string name, int count, double price, double distance) 
        : base(id, name,count, price)
    {
        this.Distance = distance;
    }
}
