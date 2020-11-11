using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Aircraft
    {
        static int flightNo = 1000;
        public string flight_name;
        public int E_level;
        public string flt_type;
        public bool EmergencyChanged;
        public int fuel_available;
        const int fuelConsume_Rate = 4; // 4 lit/sec
        Random R = new Random();

        public Aircraft(int level)
        {
            // setting flight name
            flightNo++;
            flight_name = "F-" + flightNo.ToString();
            E_level = level;
            EmergencyChanged = false;
            if (level == 2) flt_type = "Normal";
            else  flt_type = "Emergency";
            // assigning fuel available randomly
            fuel_available = R.Next(300, 800);
        }

        // method to update Fuel in an aircraft
        public void updataFuel()
        {
            if (fuel_available > 4) fuel_available = fuel_available - fuelConsume_Rate;
            else fuel_available = 0;
            
        }

    }
}
