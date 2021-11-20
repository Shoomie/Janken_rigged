class Janken_rigged
{
    static string input;
    static void Main()
    {
        Janken();
    }
    static void Janken()
    {
        Console.Clear();
        Console.WriteLine("Rock, paper or scissor?");
        input = Console.ReadLine();
        if (input == "rock")
        {
            Console.WriteLine("Paper, you lose.");
        }
        else if (input == "rock ")
        {
            Console.WriteLine("Scissors, you win.");
        }
        else if (input == "scissor")
        {
            Console.WriteLine("Rock, you lose");
        }
        else if (input == "scissor ")
        {
            Console.WriteLine("Paper, you win.");
        }
        else if (input == "paper")
        {
            Console.WriteLine("Scissor, you lose");
        }
        else if (input == "paper ")
        {
            Console.WriteLine("Rock, you win.");
        }
        else
        {
            Console.WriteLine("Please write a viable option.");
        }
        Janken();
    }
}