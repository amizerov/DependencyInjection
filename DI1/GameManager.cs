namespace DI1;

public class GameManager
{
    Random _rng = new Random();

    public RoundResult PlayRound()
    {
        Choice p1;
        do
        {
            Console.WriteLine("\nEnter Choice: (R)ock, (P)aper, or (S)cissors");
            ConsoleKey input = Console.ReadKey().Key;
            if (input == ConsoleKey.R)
            {
                p1 = Choice.Rock; break;
            }
            else if (input == ConsoleKey.P)
            {
                p1 = Choice.Paper; break;
            }
            else if (input == ConsoleKey.S)
            {
                p1 = Choice.Scissors; break;
            }
            else
                Console.WriteLine("\nInvalid choice, try again!");

        } while(true);

        Choice p2 = (Choice)_rng.Next(0, 3);
        Console.WriteLine($"\nPlayer 2 picked {p2.ToString()}");

        if(p1 == p2)
        {
            return RoundResult.Drow;
        }
        if(p1 == Choice.Rock && p2 == Choice.Scissors
        || p1 == Choice.Paper && p2 == Choice.Rock
        || p1 == Choice.Scissors && p2 == Choice.Paper)
        {
            return RoundResult.Player1Win;
        }
        return RoundResult.Player2Win;
    }
}

public enum RoundResult { Player1Win, Player2Win, Drow }
public enum Choice { Rock, Paper, Scissors}