namespace RpgGame.Service.Rounds;

public class RoundTen : Round
{
    private Player Player;

    public RoundTen(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        var ms = 1300;

        IO.Out("Efter din lilla shoppingspree går du vidare mot älgarna som är din slutstation för detta äventyr!");
        Thread.Sleep(ms);
        IO.Out("Inne bland älgarna ser du bossen för detta underbara äventyr.");
        Thread.Sleep(ms);
        IO.Out(
            $"Bossen du skall möta är ingen mindre än '{Items.Enemies[2].Name}' med sin {Items.Enemies[2].Weapon.Name}");
        Thread.Sleep(ms);
        IO.Out($"Lite bakgrund om {Items.Enemies[2].Weapon.Name}");
        Thread.Sleep(ms);
        IO.Out($"Bakgrund: {Items.Enemies[2].Weapon.Description}");
        Thread.Sleep(ms);
        IO.Out(
            $"Du klättrar över staketet för att springa mot '{Items.Enemies[2].Name}' för att visa vem som är alfan i Slottskogen.");
        Thread.Sleep(ms);
        IO.Out(
            $"'{Items.Enemies[2].Name}' bara hånler mot dig när du kommer springades som en galen webbutvecklare med för lite sömn.");
        Thread.Sleep(ms);


        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out($"Vill du anta duellen mot '{Items.Enemies[2].Name}'?");
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
                IO.Out($"Ledsen, men du kommer inte förbi '{Items.Enemies[2].Name}' utan att anta duellen..");
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

        Duel duel = new Duel(Player, Items.Enemies[2]);
        var winner = duel.startDuel();

        if (winner == "player")
        {
            IO.Out($"'{Items.Enemies[2].Name}' var en enkel match för en krigare som dig.");
            Thread.Sleep(ms);
            IO.Out("");
            IO.Out($"Med din {Player.Weapon.Name} gav du '{Items.Enemies[2].Name}' vad han tålde.");
            IO.Out("Du gick vinnade ut ur den här duellen, grattis!");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                IO.Out($"Vill du gå vidare eller stå kvar och glo på '{Items.Enemies[2].Name}'");
                Console.ForegroundColor = ConsoleColor.Cyan;
                IO.Out("[1] för att gå vidare -- [2] för att glo");


                int choosen = IO.IntIn("");
                Console.ResetColor();

                if (choosen == 2)
                {
                    Console.Clear();
                    IO.Out($"Du står kvar och glor på '{Items.Enemies[2].Name}' i fem minuter..");
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
            IO.Out($"'{Items.Enemies[2].Name}' blev för mycket av en utmaning för dig.");
            Thread.Sleep(ms);
            IO.Out($"Med sin '{Items.Enemies[2].Weapon.Name}' slog han dig gul och blå och du fick ge upp.");
            Console.ResetColor();
            Game.GameOver();
        }
    }
}