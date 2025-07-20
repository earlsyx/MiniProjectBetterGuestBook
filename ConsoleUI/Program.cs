using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Capture the inforamtion about each guest (assumptiin, ateaslst one guestt, unknown max)
// Info to capture, first name , last name, message to the host.
// Once done, loop through each guest and print their info

// Pro Tip, deisgn your app with just UI content in the UI. Put everything else in a class Library

namespace ConsoleUI
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {

            GetGuestInformation();

            PrintGuestInformation();
            
            Console.ReadLine();
        }

        private static void PrintGuestInformation()
        {

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole(message: "What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guest coming (yes/no)?: ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;

        }
    }
}
