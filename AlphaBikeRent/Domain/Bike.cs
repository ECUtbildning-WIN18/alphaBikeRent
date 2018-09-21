using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class Bike
    {
        public string RegNumber { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public string PersonalNumber { get; set; }
        public string TeleNumber { get; set; }
        public DateTime Date { get; set; }
        
        public Bike (string regNumber, string firstName, string lastName, string personalNumber, string teleNumber, DateTime date)
        {
            RegNumber = regNumber;
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            TeleNumber = teleNumber;
            Date = date;
        }
    }
}
