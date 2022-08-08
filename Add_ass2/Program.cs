Console.Write("Enter (exit) to stop me: ");
string input = Console.ReadLine();
int counter = 1;
while(counter >= 1)
{
    if(input == "exit")
    {
        Console.WriteLine("Thank you, now I can rest!");
        break;
    }
        Console.WriteLine(counter++);
        Console.Write("Enter (exit) to stop me: ");
        string input2 = Console.ReadLine();
        input = input2;

}