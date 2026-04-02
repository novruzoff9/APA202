using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01
{
    internal class Customer
    {
        private static int _id;
        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public Customer()
        {
            _id++;
            Id = _id;
        }


    }
}
