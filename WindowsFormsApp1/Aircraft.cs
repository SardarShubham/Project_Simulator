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
        const int fuel_capacity = 1000; // 1000 litres
        public int fuel_available;
        const int fuelConsume_Rate = 4; // 4 lit/sec
        Random R = new Random();

        public Aircraft(int level)
        {
            flightNo++;
            flight_name = "F-" + flightNo.ToString();
            E_level = level;
            if (level == 2)
            {
                EmergencyChanged = false;   // if normal
                flt_type = "Normal";
            }
            else
            {
                EmergencyChanged = true;
                flt_type = "Emergency";
            }
            fuel_available = R.Next(70, 800);
        }

        public void updataFuel()
        {
            fuel_available = fuel_available - 4;
            if (fuel_available < 120 && EmergencyChanged == false) EmergencyChanged = true;
        }

    }
}
