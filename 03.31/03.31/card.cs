using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._31
{
    internal class Card
    {
        private static int id;
    
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public decimal Bonus { get; set; }
        public string CardNumber { get; set; }
        public Bank Bank { get; set; }
        public Card()
        {
            id++;
            Id = id;
        }
        public bool WithDraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
