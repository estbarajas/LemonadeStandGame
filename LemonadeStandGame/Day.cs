using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        public List<Customer> customers;
        public Weather weather;
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
        }

    }
}
