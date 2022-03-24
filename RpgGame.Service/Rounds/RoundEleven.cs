namespace RpgGame.Service.Rounds;

public class RoundEleven : Round
{
    private Player Player;
    
    public RoundEleven(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        IO.Out($"Grattis {Player.Name}! Du överlevde en helg i slottskogen!");
        Console.ResetColor();
        IO.Out("");
        Game.GameOver();
    }
}