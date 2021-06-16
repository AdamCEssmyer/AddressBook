

public static List<Person>People = new List<Person>();

public class Person
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string PhoneNumber {get; set;}
    public string[] Addresses {get; set;
    }

    private static void AddPerson()
    {
        Person person = new Person();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter Phone Number:");
        person.PhoneNumber = Console.ReadLine();

        Console.Write("Enter Address 1: ");
        string[] address = new string[2];
        addresses[0] = Console.ReadLine();
        Console.Write("Enter Address 2(Optional): ");
        addresses[1] = Console.ReadLine();
        person.Addresses = addresses;
        
        People.Add(person);
    }

    private static void PrintPerson(Person person)
    {
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Phone Number: " + person.PhoneNumber);
        Console.WriteLine("Address 1: " + person.Addresses[0]);
        Console.WriteLine("Address 2: "  + person.Addresses[1]);
        Console.WriteLine("---------------------------");
    }






