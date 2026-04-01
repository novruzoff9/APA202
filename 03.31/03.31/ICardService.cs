using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._31;

internal interface ICardService
{
    void Add(Card card);
    Card Find(string cardnumber);
}
