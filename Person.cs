namespace ConsoleApp78;

public class Person
{
    private List<Person> _persons = new();
    public Person(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }
    public string Name { get; set; }
    public string LastName { get; set; }

    public void FullName()
    {
        Console.WriteLine($"full name is : {Name+" "+LastName}");
    }
}
