using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._19.Models;

internal class Fries : Food
{
    public bool IsSalt { get; set; }
    public double Weight { get; set; }
    public override double CalcPrice()
    {
        double price = Weight;
        if (IsSalt)
        {
            price += 0.8;
        }
        return price;
    }
}
