using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public readonly int MINIMUM_FARE;
        public readonly int COST_PER_KM;
        public readonly int COST_PER_MINUTE;
        public RideType ridetype;

        public Ride(double distance, int time , RideType ridetype)
        {
            this.distance = distance;
            this.time = time;
            this.ridetype = ridetype;

            if(ridetype == RideType.NORMAL)
            {
                MINIMUM_FARE = 5;
                COST_PER_KM = 10;
                COST_PER_MINUTE = 1;
            }
            else
            {
                MINIMUM_FARE = 20;
                COST_PER_KM = 15;
                COST_PER_MINUTE = 2;
            }
        }
    }
}
