// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DependencyInjection;

GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gm.PlayRound();

    if (result == RoundResult.Player1Wins)
    {
        Console.WriteLine("Player 1 Wins! ");
    }
    else if (result == RoundResult.Player2Wins)
    {
        Console.WriteLine("Player 2 Wins! ");
    }
    else Console.WriteLine("It's a draw. :(  ");

    Console.WriteLine("Play again (y/n) ? ");
} while (Console.ReadLine().ToUpper() == "Y");
