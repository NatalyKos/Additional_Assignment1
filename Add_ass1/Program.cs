Console.WriteLine("What is the answer to Life, Universe and Everything?");
Console.Write("Enter your answer here: ");
string input = Console.ReadLine();
string answer = "42";
int counter = 3;
string secret = "So long, and thanks for all the fish";
while(counter >= 1)
{
    if(input == answer)
        {
            Console.WriteLine(secret);
            break;
        }
    else
    {
        counter--;
        Console.WriteLine("You are wrong. The number of tries you have left: " + counter);
        Console.Write("Enter your answer here: ");
        string input1 = Console.ReadLine();
        input = input1;
    }
}
