using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public interface IBuyer : INameable
    {
        public void BuyFood();
        public int Food { get; }
    }
}
