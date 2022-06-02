using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy.\nStudent Daily Report");
        // prints what is your name and saves it as yourName
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();
        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();
        Console.WriteLine("What page number?");
        string page = Console.ReadLine();
        Convert.ToInt32(page);
        Console.WriteLine("Do you need help with anything? Please answer true or false.");
        string needHelp = Console.ReadLine();
        Convert.ToBoolean(needHelp);
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string posExp = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today");
        string hours = Console.ReadLine();
        Convert.ToString(hours);
        Console.WriteLine("Thank you for your answers. An instructor will responnd to this shortly. Have a great day!");
        Console.Read();
    }
}

