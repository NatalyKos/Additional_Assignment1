string name = " ";
Console.Write("Enter a command (for a list of commands enter help): ");
int password = 0;
bool isWork = true;
while (isWork)
{
    string input = Console.ReadLine().ToLower();
    
    switch (input)
    {
        case "exit":
            isWork = false;
            break;

        case "help":
            Console.WriteLine("Enter exit to stop the program");
            Console.WriteLine("Enter SetPassword to set a password");
            Console.WriteLine("Enter Knock to knock");
            Console.WriteLine("Enter CurrentDate to know the current date");
            Console.Write("Hey, " + name + " " + "enter another command: ");
            break;

        case "setpassword":
            password = ReadInt("Set a numerical password: ");
            while (ReadInt("Hey, " + name + " " + "enter the correct password to continue: ") != password)
            {
                ReadInt("Hey, " + name + " " + "enter the correct password to continue: ");
            }

            Console.Write("Hey, " + name + " " + "enter another command: ");
            break;

        case "knock":
            Console.Write("Who's there? State your name: ");
            name = Console.ReadLine();
            Console.Write("Hey, " + name + " " + "enter another command: ");
            break;

        case "currentdate":
        if(password == 0)
        {
            password = ReadInt("You haven't set a password yet. Set a numerical password: ");
            while (ReadInt("Hey, " + name + " " + "enter the correct password to continue: ") != password)
            {
                ReadInt("Hey, " + name + " " + "enter the correct password to continue: ");
            }
        }
        else
        {
            while (ReadInt("Hey, " + name + " " + "enter the correct password to continue: ") != password)
            {
                ReadInt("Hey, " + name + " " + "enter the correct password to continue: ");
            }
        }
            Console.WriteLine(DateTime.Now + " " + name);
            Console.Write("Hey, " + name + " " + "enter another command: ");
            break;
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}