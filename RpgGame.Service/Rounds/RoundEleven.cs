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
        IO.Out($"Grattis {Player.Name}! Du överlevde en helg i slottskogen!");
        Game.GameOver();
    }
}