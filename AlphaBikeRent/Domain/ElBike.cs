using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class ElBike : Bike
    { 
        public ElBike (string regNumber, string firstName, string lastName, string personalNumber, string teleNumber, int rentalperiod, int costPerDay)
         : base (regNumber, firstName, lastName, personalNumber, teleNumber, rentalperiod, 200)
        {
        }
    }
}
