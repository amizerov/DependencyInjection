namespace DI2;

public class GameManager
{
    IPlayer _player1;
    IPlayer _player2;

    public GameManager(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public RoundResult PlayRound()
    {
        Choice p1 = _player1.GetChoice();
        Choice p2 = _player2.GetChoice();

        Console.WriteLine($"\nPlayer 1 picked {p1.ToString()} and Player 2 picked {p2.ToString()}");

        if (p1 == p2)
        {
            return RoundResult.Drow;
        }
        if (p1 == Choice.Rock && p2 == Choice.Scissors
         || p1 == Choice.Paper && p2 == Choice.Rock
         || p1 == Choice.Scissors && p2 == Choice.Paper)
        {
            return RoundResult.Player1Win;
        }
        return RoundResult.Player2Win;
    }
}

public enum RoundResult { Player1Win, Player2Win, Drow }
public enum Choice { Rock, Paper, Scissors }