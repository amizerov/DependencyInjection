using DI2;

GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult result = gm.PlayRound();

    if (result == RoundResult.Player1Win)
        Console.WriteLine("Player 1 Win!");
    else if (result == RoundResult.Player2Win)
        Console.WriteLine("Player 2 Win!");
    else
        Console.WriteLine("It's a draw!");

    Console.WriteLine("Play again (Y/N)?");
}
while (Console.ReadKey().Key == ConsoleKey.Y);