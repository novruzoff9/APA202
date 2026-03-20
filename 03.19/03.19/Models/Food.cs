namespace _03._19.Models;

internal abstract class Food
{
    public int Id { get; set; }
    public string Name { get; set; }
    private double _calory;
    public double Calory
    {
        get
        {
            return _calory;
        }
        set
        {
            if (value > 0)
            {
                _calory = value;
            }
        }
    }
    public abstract double CalcPrice();
}
