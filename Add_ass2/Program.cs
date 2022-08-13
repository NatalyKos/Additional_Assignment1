string name = " ";
Console.Write("Enter a command (for a list of commands enter help): ");
string input = Console.ReadLine();
while(input != "exit")
{
    
    switch (input)
    {
        case "exit":
        break;

        case "help":
        Console.WriteLine("Enter exit to stop the program");
        Console.WriteLine("Enter SetPassword to set a password");
        Console.WriteLine("Enter Knock to knock");
        Console.WriteLine("Enter CurrentDate to know the current date");
        Console.Write("Hey, " + name + " " + "enter another command: ");
        input = Console.ReadLine();
        break;

        case "SetPassword":
        int password = ReadInt("Set a numerical password: ");
        while(ReadInt("Hey, " + name + " " + "enter the correct password to continue: ") != password)
        {
            ReadInt("Hey, " + name + " " + "enter the correct password to continue: ");
            
        }
        Console.Write("Hey, " + name + " " + "enter another command: ");
        input = Console.ReadLine();
        break;

        case "Knock":
        Console.Write("Who's there? State your name: ");
        name = Console.ReadLine();
        Console.Write("Hey, " + name + " " + "enter another command: ");
        input = Console.ReadLine();
        break;

        case "CurrentDate":
        Console.WriteLine(DateTime.Now + " " + name );
        Console.Write("Hey, " + name + " " + "enter another command: ");
        input = Console.ReadLine();
        break;
        
    }
    
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}