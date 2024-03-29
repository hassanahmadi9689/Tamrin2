﻿// See https://aka.ms/new-console-template for more information

using ConsoleApp78;

while (true)
{
    try
    {
        run();

    }
    catch (Exception exception)
    {
        ShowError(exception.Message);
    }
}

void run()
{
    var option = GetNumberFromUser("choose:\n" +
                                   "1.add person\n" +
                                   "2.show list\n" );
    switch (option)
    {
        case 1:
        {
            var name = GetValiNameFromUser("enter first name:");
            var lastname = GetValiNameFromUser("enter last name");
            FullName.AddPerson(name,lastname);
            break;
        }
        case 2:
        {
            foreach (var person in FullName.GetList())
            {
                Console.WriteLine(person.Name+" "+person.LastName);
            }
            break;
        }
        
        default:
            Console.WriteLine("wrong choose");
            break;
    }
}















 static string GetValiNameFromUser( string message)
{
    string? studentFullName;
    do
    {
        Console.WriteLine(message);
        studentFullName = Console.ReadLine().ToLower();
    } while (string.IsNullOrWhiteSpace(studentFullName) ||
             studentFullName.Length > 120);

    return studentFullName;
}
static int GetNumberFromUser(string message)
{
    var resultTryParseFirstNumber = false;
    int number;
    do
    {
        Console.WriteLine(message);
        resultTryParseFirstNumber =
            int.TryParse(Console.ReadLine(), out number);
    } while (!resultTryParseFirstNumber );

    return number;
}

    
static void ShowError(string error)
{
    Console.WriteLine("*********");
    Console.WriteLine(error);
    Console.WriteLine("*********");
}