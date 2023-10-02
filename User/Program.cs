class User
{
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate; //  field "date of completing the questionnaire"

    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; // only one initialization while creating
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine($"Login: {login}");
        Console.WriteLine($"Name: {firstName}");
        Console.WriteLine($"Surname: {lastName}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Date of completing the questionn aire: {registrationDate}");
    }
}

class Program
{
    static void Main()
    {
        // Specimen of class User
        User user = new User("Abobebra223", "Petya", "Mc", 55);

        user.DisplayUserInfo();

        Console.ReadLine();
    }
}