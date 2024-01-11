namespace ConsoleApp78;

public static class FullName
{
    private static List<Person> _persons = new();

    public static void AddPerson(string name, string lastname)
    {
        var person = new Person(name, lastname);
        person.FullName();
        _persons.Add(person);
    }

    public static List<Person> GetList()
    {
        return _persons;
    }
}