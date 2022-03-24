namespace RpgGame.Service.Rounds;

public class RoundFour : Round
{
    private Player Player;

    public RoundFour(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var ms = 1300;

        IO.Out("Du traskar vidare upp emot 'Vita villan'..");
        Thread.Sleep(ms);
        IO.Out("På avstånd ser du en person som kanske fått i sig något olagligt..");
        Thread.Sleep(ms);
        IO.Out($"Han viftar friskt med vad som ser ut som på avstånd ser ut som en {Items.Enemies[0].Weapon.Name}.");
        IO.Out("");
        Thread.Sleep(ms);
        IO.Out(
            $"När du närmar dig så ser du att det är '{Items.Enemies[0].Name}' från hamnen som står där och viftar med sin {Items.Enemies[0].Weapon.Name}");
        Thread.Sleep(ms);
        IO.Out($"När '{Items.Enemies[0].Name}' får syn på dig börjar han vråla om att utmana dig i en duell..");
        IO.Out("");
        Thread.Sleep(ms);


        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out($"Vill du anta duellen mot '{Items.Enemies[0].Name}'?");
            IO.Out("");
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("[1] för att anta -- [2] för att låta bli");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var inputAnswerDuel = IO.IntIn("Gör ditt val: ");
            Console.ResetColor();

            if (inputAnswerDuel != 1)
            {
                IO.Out("", true);
                Console.ForegroundColor = ConsoleColor.Magenta;
                IO.Out($"Ledsen, men du kommer inte förbi '{Items.Enemies[0].Name}' utan att anta duellen..");
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

        Duel duel = new Duel(Player, Items.Enemies[0]);
        var winner = duel.startDuel();

        if (winner == "player")
        {
            Thread.Sleep(ms);
            IO.Out($"{Items.Enemies[0].Name} var en enkel match för en krigare som dig.");
            Thread.Sleep(ms);
            IO.Out($"Med din {Player.Weapon.Name} gav du {Items.Enemies[0].Name} vad han tålde.");
            Thread.Sleep(ms);
            IO.Out("Du gick vinnade ut ur den här duellen, grattis!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                IO.Out($"Vill du gå vidare eller stå kvar och glo på {Items.Enemies[0].Name}");
                IO.Out("");
                Console.ForegroundColor = ConsoleColor.Cyan;
                IO.Out("[1] för att gå vidare -- [2] för att glo");


                int choosen = IO.IntIn("");
                Console.ResetColor();

                if (choosen == 2)
                {
                    Console.Clear();
                    IO.Out($"Du står kvar och glor på '{Items.Enemies[0].Name}' i fem minuter..");
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
            Console.ForegroundColor = ConsoleColor.Red;
            IO.Out("");
            IO.Out($"{Items.Enemies[0].Name} blev för mycket av en utmaning för dig.");
            Thread.Sleep(ms);
            IO.Out($"Med sin {Items.Enemies[0].Weapon} slog han dig gul och blå och du fick ge upp.");
            Console.ResetColor();
            Game.GameOver();
        }
    }
}