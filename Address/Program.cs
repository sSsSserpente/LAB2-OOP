class Address
{
    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}

class Program
{
    static void Main()
    {
        Address myAddress = new Address();

        myAddress.Index = "07415";
        myAddress.Country = "Ukraine";
        myAddress.City = "Zazymie";
        myAddress.Street = "Trostyanetska street";
        myAddress.House = "2";
        myAddress.Apartment = "1";

        Console.WriteLine("Index: " + myAddress.Index);
        Console.WriteLine("Country: " + myAddress.Country);
        Console.WriteLine("City: " + myAddress.City);
        Console.WriteLine("Street: " + myAddress.Street);
        Console.WriteLine("House: " + myAddress.House);
        Console.WriteLine("Apartment: " + myAddress.Apartment);

        Console.ReadLine(); 
    }
}
