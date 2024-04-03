namespace PhoneBook;

public class PhoneBook
{
    public List<Contact> Contacts { get; set; } = new List<Contact>();

    public void AddContacts(Contact contact)
    {
        Contacts.Add(contact);
    }

    private void ContactDetails(Contact contact)
    {
        Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
    }

    public void DisplayContact(string number)
    {
        var contact = Contacts.FirstOrDefault(c => c.Number == number);

        if (contact == null)
        {
            Console.WriteLine("Contact not found");
        }
        else
        {
            ContactDetails(contact);

        }
    }

    public void DisplayAllContacts()
    {
        foreach (var contact in Contacts)
        {
            ContactDetails(contact);
        }
    }

    public void MatchingContacts(string searchPhrase)
    {
        var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
        foreach (var contact in matchingContacts)
        {
            ContactDetails(contact);
        }
    }
}
