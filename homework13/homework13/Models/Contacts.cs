namespace homework13.Models;

public class Contacts
{
    public string Name { get; set; }
    public DateTime AddDate { get; set; }
    public string PhoneNumber { get; set; }

    public Contacts(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        AddDate = DateTime.Now;
    }


}
