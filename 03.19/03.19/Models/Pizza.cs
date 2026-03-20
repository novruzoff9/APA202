using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03._19.Models;

internal class Pizza : Food
{
    public int Radius { get; set; }
    public bool IsHot { get; set; }
    public override double CalcPrice()
    {
        double price = 3.14 * Radius * Radius*0.1;
        if (IsHot)
            price += 1.15;
        return price;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Calory {Calory}, Radius {Radius}";
    }
}
