namespace RpgGame.Service.Rounds;

public class RoundSeven : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }

    private Player Player;

    public RoundSeven(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var ms = 1000;

        IO.Out("Efter din lilla shoppingspree går du vidare på Plantskolevägen");
        //Thread.Sleep(ms);
        IO.Out("Borta vid volleybollplanerna ser du ännu en 'hamnare'.");
        //Thread.Sleep(ms);
        IO.Out("Även han har nog varit på flaskan lite väl tidigt på dagen, så att säga..");
        //Thread.Sleep(ms);
        IO.Out(
            $"När du är på ett behagligt men ändå nära avstånd ser du att det är {Items.Enemies[1].Name} som står och gormar.");
        //Thread.Sleep(ms);
        IO.Out(
            $"Han ser ut att försöka jaga duvor med ett {Items.Enemies[1].Weapon.Name} när han plötsligt får syn på dig..");
        //Thread.Sleep(ms);
        IO.Out($"{Items.Enemies[1].Name} vill även han utmanda dig i en duell om Azaleadalen!");
        //Thread.Sleep(ms);


        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out($"Vill du anta duellen mot '{Items.Enemies[1].Name}'?");
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("[1] för att anta -- [2] för att låta bli");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var inputAnswerDuel = IO.IntIn("Gör ditt val: ");
            Console.ResetColor();

            if (inputAnswerDuel != 1)
            {
                IO.Out("", true);
                Console.ForegroundColor = ConsoleColor.Magenta;
                IO.Out($"Ledsen, men du kommer inte förbi '{Items.Enemies[1].Name}' utan att anta duellen..");
                IO.Out("");
                Console.ResetColor();
            }

            if (inputAnswerDuel == 1)
            {
                IO.Out("", true);
                IO.Out($"Dags för din första duell!");
                break;
            }
        }

        Duel duel = new Duel(Player, Items.Enemies[1]);
        var winner = duel.startDuel();

        if (winner == "player")
        {
            IO.Out($"{Items.Enemies[1].Name} var en enkel match för en krigare som dig.");
            IO.Out($"Med din {Player.Weapon.Name} gav du {Items.Enemies[1].Name} vad han tålde.");
            IO.Out("Du gick vinnade ut ur den här duellen, grattis!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                IO.Out($"Vill du gå vidare eller stå kvar och glo på {Items.Enemies[1].Name}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                IO.Out("[1] för att gå vidare -- [2] för att glo");


                int choosen = IO.IntIn("");
                Console.ResetColor();

                if (choosen == 2)
                {
                    Console.Clear();
                    IO.Out($"Du står kvar och glor på {Items.Enemies[1].Name} i fem minuter..");
                }

                if (choosen == 1)
                {
                    Console.Clear();
                    Console.ResetColor();
                    break;
                }
            }
        }
        else
        {
            IO.Out($"{Items.Enemies[1].Name} blev för mycket av en utmaning för dig.");
            IO.Out($"Med sin {Items.Enemies[1].Weapon.Name} slog han dig gul och blå och du fick ge upp.");
            Game.GameOver();
        }
    }
}