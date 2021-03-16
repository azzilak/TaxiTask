using System;

namespace Apps_Taxi
{
    public class Taxi
    {
        //PROPERTIES
        public string DriverName { get; set; }
        public bool onDutty { get; set; }
        public float numbPassenger { get; set; }


        //METHOD
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name              : {0}", DriverName);

            if (onDutty == true)
            {
                Console.WriteLine("Taxi On Duty             : Yes", onDutty);

            }

            if (onDutty == false)
            {
                Console.WriteLine("Taxi On Duty                  : No", onDutty);
            }
            
            Console.WriteLine("Numb. of the Passenger   : {0}", numbPassenger);
        }

        public void PickUp()
        {
            Console.WriteLine("\n {0} sedang menjemput penumpang", DriverName);
        }

        public void DropOff()
        {
            Console.WriteLine("{0} telah selesai mengantar penumpang \n", DriverName);
        }
    }
}
