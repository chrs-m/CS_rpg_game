namespace RpgGame.Service.Rounds;

public class RoundTwo : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }
    
    private Player Player;
    
    public RoundTwo(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var random = new Random();
        int index = random.Next(Items.Food.Count);
        var randomFood = Items.Food[index];
        
        IO.Out($"När du kommer till säldammen så ser du {randomFood.Name} på marken.");
        IO.Out("Vill du plocka upp och förtära det du hittade?");
        IO.Out("1 för ja, 2 för nej");
        var inputAnswer = IO.IntIn("Gör ditt val: ");
        
        if (inputAnswer == 1)
        {
            Player.Consume(randomFood);
            IO.Out($"Du förtärde {randomFood.Name}, ditt hp är nu {Player.Hp}");
        }
        //random food/object round
        //choose to take food/object

        //message
        //choice
        //events
        //outcome
        //move on
    }
}