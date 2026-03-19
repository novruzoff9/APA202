namespace _03._17;

internal class Vehicle
{
    private string _brand;
    public string Brand
    {
        get
        {
            return _brand;
        }
        set
        {
            if(value.Length >= 3)
                _brand = value;
            else
                Console.WriteLine("Minimum 3 simvol olmalidir");
        }
    }

    private string _model;
    public string Model
    {
        get
        {
            return _model;
        }
        set
        {
            if (value.Length >= 3)
                _model = value;
            else
                Console.WriteLine("Minimum 3 simvol olmalidir");
        }
    }

    private int _year;
    public int Year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value >= 1900)
                _year = value;
            else
                Console.WriteLine("Minimum il 1900 olmalidir");
        }
    }

    public int MileageKm { get; set; }
    public bool IsRunning { get; set; }
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void StartEngine() => IsRunning = true;
    public void StopEngine() => IsRunning = false;
    public void Drive(int km)
    {
        if (IsRunning)
            MileageKm += km;
        else
            Console.WriteLine("Muherrik islek deyil");
    }

    public void VehicleInfo()
    {
        Console.WriteLine($"Brand {Brand}");
        Console.WriteLine($"Model {Model}");
        Console.WriteLine($"Year {Year}");
        Console.WriteLine($"Mileage {MileageKm}km");
        Console.WriteLine($"Running {IsRunning}");
    }
}
