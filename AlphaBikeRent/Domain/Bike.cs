using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class Bike
    {
        public string RegNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int RentalPeriod { get; set; }
        public int CostPerDay { get; set; }

        public Bike(string regNumber, string firstName, string lastName, string personalNumber, string phoneNumber, int rentalPeriod, int costPerDay)
        {
            RegNumber = regNumber;
            FirstName = firstName;
            LastName = lastName;
            PersonalNumber = personalNumber;
            PhoneNumber = phoneNumber;
            RentalPeriod = rentalPeriod;
            CostPerDay = costPerDay;
        }

        public void Register()
        {
            Console.Clear();

            Console.WriteLine("Firstname: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Lastname: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Personalnumber:");
            PersonalNumber = Console.ReadLine();

            Console.WriteLine("Phonenumber:");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("RentalPeriod:");
            RentalPeriod = int.Parse(Console.ReadLine());

            TotalCost();
            PrintConfirmation();
        }

        public int totalcost;

        public void TotalCost()
        {
            totalcost = RentalPeriod * CostPerDay;
        }
        
        public void PrintConfirmation()
        {
            Console.Clear();
            Console.WriteLine($"Firstname: {FirstName}");
            Console.WriteLine($"Lastname: {LastName}");
            Console.WriteLine($"Personalnumber: {PersonalNumber}");
            Console.WriteLine($"Phonenumber: {PhoneNumber}");
            Console.WriteLine($"Rentalperiod: {RentalPeriod}");

            Console.WriteLine($"Your totalcost will be: {totalcost}");
        }
    }
}
