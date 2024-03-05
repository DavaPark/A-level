using System;

namespace Homework15;

class Program
{
    static void Main(string[] args)
    {
        List<Contact> contacts = new List<Contact>()
    {
        new Contact { Name = "David", NumberPhone = 380-975-675-676 },
        new Contact { Name = "Alex", NumberPhone = 380-985-439-009 },
        new Contact { Name = "Marina", NumberPhone = 380-934-328-798},
        new Contact { Name = "Ivan", NumberPhone = 380-952-554-554},
        new Contact { Name = "Milana", NumberPhone = 380-934-567-123},
    };
        //1
        Contact contact1 = contacts.FirstOrDefault(x => x.NumberPhone == 380 - 975 - 675 - 676);
        if (contact1 != null)
            Console.WriteLine("Контакт с номером 380-975-675-676: " + contact1.Name);
        else
            Console.WriteLine("Контакт с номером 380-975-675-676 не найден");

        Console.WriteLine("");


        //2
        var filteredContacts = contacts.Where(x => x.Name.StartsWith("M"));
        Console.WriteLine("Имена контактов,которые начинается на Буквы М: ");
        foreach( var contact in filteredContacts)
        {
            Console.WriteLine(contact.Name);
        }

        Console.WriteLine("");


        //3
        var names = contacts.Select(x => x.Name).ToList();
        Console.WriteLine("Список имён:");
        foreach ( var name in names) Console.WriteLine(name);

        Console.WriteLine("");


        //4
        var count = contacts.Count();
        Console.WriteLine("Колличество контактов: " + count);
        
        Console.WriteLine("");

        //5
        var sortedContacts = contacts.OrderBy(x => x.Name);
        Console.WriteLine("Сортирует в алфовитном подряке: ");
        foreach ( var contact in sortedContacts)
        {
            Console.WriteLine(contact.Name);
        }

        Console.WriteLine("");

        //6
        string searchName = "David";
        var hasContact = contacts.Any(x => x.Name == searchName);
        if(hasContact)
        {
            Console.WriteLine("Контакт с именем " + searchName + " найден");
        }
        else
        {
            Console.WriteLine("Контакт с именем " + searchName + " не найден");
        }


    }
}

