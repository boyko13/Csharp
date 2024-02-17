namespace PhoneBook;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Welcome to the phone book! ");
        Console.WriteLine("What you want to do?");
        Console.WriteLine("'1' to add the contact ");
        Console.WriteLine("'2' Display contact by number ");
        Console.WriteLine("'3' Display all contract");
        Console.WriteLine("'4' Search contracts");
        Console.WriteLine("To exit click 'x'");

        var userInput = Console.ReadLine();

        var phoneBook = new PhoneBook();


        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Insert Name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Insert Number: ");
                    var number = Console.ReadLine();

                    var newContract = new Contact(name, number);
                    phoneBook.AddContacts(newContract);
                    break;

                case "2":

                    Console.WriteLine("Provide the number");
                    var numberToSearch = Console.ReadLine();
                    phoneBook.DisplayContact(numberToSearch);
                    break;

                case "3":
                    Console.WriteLine();
                    foreach (var contact in phoneBook.Contacts)
                    {
                        Console.WriteLine($"Name: " + contact.Name);
                        Console.WriteLine($"Number: " + contact.Number);
                    }
                    break;

                case "4":
                    Console.WriteLine("Please provide Name:");
                    var search = Console.ReadLine();
                    phoneBook.MatchingContacts(search);
                    
                    break;
                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid Syntax");
                    break;
            }
            Console.WriteLine("Select Operation: ");
            userInput = Console.ReadLine();
        }






    }
}