using System.Globalization;
using homework13.Models;

namespace homework13.Services
{
    public class ContactsCollection
    {
        private List<Contacts> contacts;

        public ContactsCollection()
        {
            contacts = new List<Contacts>();
        }

        public void AddContact(Contacts contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(Contacts contact)
        {
            contacts.Remove(contact);
        }

        public void DisplayContactsGroupedByAlphabet(CultureInfo culture = null)
        {
            if (culture == null || !CultureInfo.GetCultures(CultureTypes.AllCultures).Contains(culture))
            {
                culture = CultureInfo.InvariantCulture;
            }

            var groupedContacts = contacts
                .OrderBy(c => c.Name, StringComparer.Create(culture, true)) 
                .GroupBy(c => DetermineGroupKey(c.Name, culture)); 

            foreach (var group in groupedContacts)
            {
                
                foreach (var contact in group)
                {
                    Console.WriteLine($"Name: {contact.Name}, Phone Number: {contact.PhoneNumber}, Added Date: {contact.AddDate}");
                }
                Console.WriteLine();
            }
        }

        private string DetermineGroupKey(string name, CultureInfo culture)
        {
            string[] englishMonthNames = CultureInfo.InvariantCulture.DateTimeFormat.AbbreviatedMonthNames;

            if (string.IsNullOrWhiteSpace(name))
            {
                return "#"; 
            }
            else if (char.IsDigit(name[0]))
            {
                return "0-9"; 
            }
            else
            {
                string firstLetter = name[0].ToString().ToUpper(culture);
                if (!char.IsLetter(firstLetter[0]) || Array.IndexOf(englishMonthNames, firstLetter) == -1)
                {
                    return "#";
                }
                return firstLetter;
            }
        }
    }
}