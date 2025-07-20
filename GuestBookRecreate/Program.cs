

// Guest book
// Ask guest for their names, first name , last name.
// Ask what message to the host
// Ask if they want to add more.
// Print guestt list and host message

using GuestBookRecreateLibrary.Models;

 
List<GuestModel> guests = new List<GuestModel>();
GetGuestInformation(guests);
PrintGuestINfo(guests);


//do
//{
//    GuestModel guest = new GuestModel();
//    string addMoreGuest = "";

//    guest.FirstName = GetMessageFromConsole("What is your first name: ");
//    guest.LastName = GetMessageFromConsole("What is your last name: ");
//    guest.MessageToHost = GetMessageFromConsole("What is your message to the host: ");
//    addMoreGuest = GetMessageFromConsole("Do you want to add more guest (yes/no)?: ");
//    guests.Add(guest);

//    Console.Clear();

//} while (addMoreGuest.ToLower() == "yes");

static void GetGuestInformation(List<GuestModel> guests)
{
    string moreGuestsComing = "";
    do
    {
        GuestModel guest = new GuestModel();

        guest.FirstName = GetMessageFromConsole("What is your first name: ");
        guest.LastName = GetMessageFromConsole("What is your last name: ");
        guest.MessageToHost = GetMessageFromConsole(message: "What message would you like to tell your host: ");
        moreGuestsComing = GetMessageFromConsole("Are more guest coming (yes/no)?: ");

        guests.Add(guest);

        Console.Clear();
    } while (moreGuestsComing.ToLower() == "yes");
}


static string GetMessageFromConsole(string message)
{
    Console.WriteLine(message);
	string answer = Console.ReadLine();

	return answer;
}

static void PrintGuestINfo(List<GuestModel> guests)
{
    foreach (GuestModel guest in guests)
    {
        Console.WriteLine(guest.GetGuestInfo);
    }
}