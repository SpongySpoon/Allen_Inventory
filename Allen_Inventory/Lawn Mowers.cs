using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allen_Inventory
{
    class Lawn_Mowers : IShippable
    {
        

        public decimal ShipCost
        {
            get { return 24.00m; }
        }

        public string Product
        {
            get { return "Lawn Mowers"; }
        }
    }
}
