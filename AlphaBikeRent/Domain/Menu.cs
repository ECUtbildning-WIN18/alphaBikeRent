using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class Menu
    {
        public Menu()
        {

        }
        public void RunningMenu()
        {
            Console.WriteLine("--------Welcome to Alpha Bikerental--------");
            int usersChoice = 0;
            do
            {
                bool loop = true;
                do
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose by following options");
                    Console.WriteLine("Renting a ordinary bike, press 1 ");
                    Console.WriteLine("Renting a electric bike, press 2");
                    Console.WriteLine("for xxxx, press 3 ");
                    Console.WriteLine("Press 0 to exit the application");
                    Console.Write(">>");

                    try
                    {
                        usersChoice = int.Parse(Console.ReadLine());
                        loop = false;
                    }
                    catch
                    {
                        Console.WriteLine("You are only allowed to type numbers between 0-3");
                    }
                } while (loop);

                switch (usersChoice)
                {
                    case 1: //RentOrdinaryBike();
                        break;

                    case 2: //RentElectricBike():
                        break;
                    case 3: //DoSomething();
                        break;
                    case 0:
                        Console.WriteLine("Welcome back!");
                        break;

                }

            } while (usersChoice != 0);

        }
    }
}
