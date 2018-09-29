using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class RegBike : Bike
    {       
        public RegBike(string regNumber, string firstName, string lastName, string personalNumber, string teleNumber, int rentalPeriod, int costPerDay)
           : base(regNumber, firstName, lastName, personalNumber, teleNumber, rentalPeriod, 100)
        { 
        }
    }
}
