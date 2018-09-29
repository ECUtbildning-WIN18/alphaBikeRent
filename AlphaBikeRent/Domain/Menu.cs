using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaBikeRent.Domain
{
    class Menu
    {
        Bike bike = new Bike(null, null, null, null, null, 0, 0);

        public void RunningMenu()
        {
            Console.WriteLine("--------Welcome to Alpha Bikerental--------");
            int usersChoice = 0;
            bool loop = true;
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("Choose by following options");
                Console.WriteLine("Renting a ordinary bike (100 SEK/day), press 1 ");
                Console.WriteLine("Renting a electric bike (200 SEK/day), press 2");
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
                case 1:
                    bike = new RegBike(null, null, null, null, null, 0, 0);
                    Console.Clear();
                    Console.WriteLine("You have chosen Regularbike!");
                    bike.Register();
                    Confirm();
                    //        if(!Confirm())            //Detta är ett alternativ till ovan metod Confirm, ifall Confirm-metoden returnerar bool
                    //{
                    //    RunningMenu();
                    //}
                    break;

                case 2:
                    bike = new ElBike(null, null, null, null, null, 0, 0);
                    Console.Clear();
                    Console.WriteLine("You have chosen Elbike!");
                    bike.Register();
                    Confirm();
                    break;

                case 0:
                    Console.WriteLine("Welcome back!");
                    break;

                default:
                    RunningMenu();
                    break;
            }
        }

        public void Confirm()
        {
            Console.WriteLine("\nAre you happy? Type y or n: ");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.Clear();
                Console.WriteLine("Thank you for your rental!");
            }
            else
            {
                Console.Clear();
                RunningMenu();
            }
        }
    }
}
