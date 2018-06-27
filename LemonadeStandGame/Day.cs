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
        public int dayOfWeek;
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            dayOfWeek = 0;
        }

        public void increaseDayOfWeek()
        {
            dayOfWeek++;
            Console.WriteLine("Current day: " + dayOfWeek);
        }
     
    }
}
