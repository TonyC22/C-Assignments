using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise162
{
    public class AuctionCars
    {
        public AuctionCars(string CarTent) : this(CarTent, 1000)
        {
            return;
        }
        public AuctionCars(string carTent, int cars)
        {
            CarTent = carTent;
            AllCars =  10000;
        }
        public string CarTent { get; set; }
        public int AllCars { get; set; }
    }
}
