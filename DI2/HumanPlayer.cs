namespace DI2;

public class HumanPlayer : IPlayer
{
    public Choice GetChoice()
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

        } while (true);

        return p1;
    }
}
