using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01
{
    internal class Courier
    {
        private static int _id;
        public int Id { get; set; }
        
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        
        public Courier()
        {
            _id++;
            Id = _id;
        }
    }
}
