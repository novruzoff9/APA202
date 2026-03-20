using _03._19.Models;

namespace _03._19;

internal interface IFoodService
{
    int MustCalories(Food[] foods, int n);
    double MaxRadius(Pizza[] pizzas);
}

internal class FoodService : IFoodService
{
    public int MustCalories(Food[] foods, int n)
    {
        int count = 0;
        foreach (var item in foods)
        {
            if (item.Calory > n)
                count++;
        }
        return count;
    }

    public double MaxRadius(Pizza[] pizzas)
    {
        double maxRadius = pizzas[0].Radius;

        foreach (var pizza in pizzas)
        {
            if (pizza.Radius > maxRadius)
            {
                maxRadius = pizza.Radius;
            }
        }
        return maxRadius;
    }
}
