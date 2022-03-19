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
        var ms = 1000;
        
        var random = new Random();
        int index = random.Next(Items.Food.Count);
        var randomFood = Items.Food[index];
        
        IO.Out($"När du kommer till säldammen så ser du {randomFood.Name} på marken.");
        IO.Out("Vill du plocka upp och förtära det du hittade?");
        Console.ForegroundColor = ConsoleColor.Green;
        IO.Out("[1] för Ja -- [2] för Nej");
        Console.ForegroundColor = ConsoleColor.Cyan;
        var inputAnswerFood = IO.IntIn("Gör ditt val: ");
        Console.ResetColor();
        
        if (inputAnswerFood == 1)
        {
            IO.Out("",true);
            Player.Consume(randomFood);

            if (randomFood.Modifier < 0)
            {
                IO.Out("");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                IO.Out($"Du förtärde {randomFood.Name}, ditt hp är nu {Player.Hp}");
                Console.ResetColor();
                IO.Out("");
            }
            if(randomFood.Modifier > 1)
            {
                IO.Out("");
                Console.ForegroundColor = ConsoleColor.Green;
                IO.Out($"Du förtärde {randomFood.Name}, ditt hp är nu {Player.Hp}");
                Console.ResetColor();
                IO.Out(""); 
            }
         
        }
        
        if (inputAnswerFood == 2)
        {
            IO.Out("", true);
            IO.Out($"Du valde att slänga {randomFood.Name} till sälarna, ditt hp är kvar på {Player.Hp}");
        }

        while (true)
        {
            // Thread.Sleep(ms);
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("Vill du stanna lite till eller gå vidare?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            IO.Out("[1] för att stanna -- [2] för att gå vidare");
            int choosen = IO.IntIn("");
            Console.ResetColor();

            if (choosen == 2)
            {
                break;
            }
            IO.Out("", true);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out("Du stannar kvar och försöker beundra sälarna som inte syns till..");
            Console.ResetColor();
        }
    }
}