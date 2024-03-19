using homework13.Models;
using homework13.Services;
using System.Globalization;

namespace homework13;

public class Startup
{
    public void App()
    {
        var contactsCollection = new ContactsCollection();
        contactsCollection.AddContact(new Contacts("John", "123-456-7890"));
        contactsCollection.AddContact(new Contacts("Андрій", "098-765-4321"));


        Console.WriteLine("Enter contact details (name and phone number) or enter 'done' to finish:");

        while (true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "done")
                break;

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();


            contactsCollection.AddContact(new Contacts(name, phoneNumber));
        }


        Console.WriteLine("Contacts grouped by alphabet (English):");
        contactsCollection.DisplayContactsGroupedByAlphabet(new CultureInfo("en-US"));

        Console.WriteLine("Contacts grouped by alphabet (Ukrainian):");
        contactsCollection.DisplayContactsGroupedByAlphabet(new CultureInfo("uk-UA"));
    }
}
