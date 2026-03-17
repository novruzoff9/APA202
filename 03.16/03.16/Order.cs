using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._16
{
    internal class Order
    {
        public int Id;
        public string Name;
        public int Count;
        public double Price;

        public Order(int id,string name,int count,double price)
        {
            this.Id = id;
            this.Name = name;
            this.Count = count;
            this.Price = price;
        }
        public Order(int id,string name,double price)
        {
            this.Id = id;
            this.Name = name;
            this.Count = 1;
            this.Price = price;  

        }
        public double TotalPrice()
        {
            return Count * Price;
        }
        public void Increase(int n)
        {
            Count += n;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"adi: {Name},Qiymet{Price}, Miqdar {Count}, Umumi Qiymet {TotalPrice()}");
        }

    }
}
