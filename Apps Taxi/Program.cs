using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Mas Ojol";
            taxi.onDutty = true;
            taxi.numbPassenger = 7;

            taxi.TaxiInfo();
            taxi.PickUp();
            taxi.DropOff();

            Console.ReadKey();
        }
    }
}
