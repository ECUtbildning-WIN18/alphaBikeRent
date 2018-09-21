using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class RegBike : Bike
    {
        public RegBike(string regNumber, string firstName, string lastName, string personalNumber, string teleNumber, DateTime date)
            : base(regNumber, firstName, lastName, personalNumber, teleNumber, date)
        {

        }
    }
}
