using RpgGame.Service.Rounds;

namespace RpgGame.Service;

public class Game
{
    private Player player;

    public void StartGame()
    {
        int menuItem = printMenu();

        if (menuItem == 1)
        {
            Console.Clear();
            string name = IO.StringIn("Välj ett namn: ");

            player = new Player(name, 20, Items.Weapons[0], 0);

            Items.Enemies.Clear();

            Items.Enemies.Add(new Enemy("Piss i huvet", 15, "enemy",
                new Weapon("Repstump", 3, $"En bit rep som 'Piss i huvet' tagit med sig från hamnen.", 0)));

            Items.Enemies.Add(new Enemy("Gissa mitt jobb", 30, "enemy",
                new Weapon("Vässat stolsben", 10, $"Efter slagsmål i hamnen så fick 'Gissa mitt jobb' med sig detta hem.", 0)));

            Items.Enemies.Add(new Enemy("Tjuven i Baghdad", 70, "boss",
                new Weapon("Shamshir stulen i Baghdad", 20, "Föremålet behöver ingen närmre beskrvining..", 0)));

            new RoundOne(player).StartRound();
            Console.Clear();
            new RoundTwo(player).StartRound();
            Console.Clear();
            new RoundThree(player).StartRound();
            Console.Clear();
            new RoundFour(player).StartRound();
            Console.Clear();
            new RoundFive(player).StartRound();
            Console.Clear();
            new RoundShop(player).StartRound();
            Console.Clear();
            new RoundSeven(player).StartRound();
            Console.Clear();
            new RoundEight(player).StartRound();
            Console.Clear();
            new RoundShop(player).StartRound();
            Console.Clear();
            new RoundTen(player).StartRound();
            Console.Clear();
            new RoundEleven(player).StartRound();
        }
    }

    private int printMenu()
    {
        int choosenMenu = 0;
        bool isValidInput = false; // Keep while loop running

        while (!isValidInput)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("--- Välkommen till RPGBG ---");
            Console.ResetColor();
            IO.Out("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            IO.Out("1. Starta nytt spel");
            IO.Out("9. Avsluta");
            Console.ResetColor();
            IO.Out("");

            Console.ForegroundColor = ConsoleColor.Cyan;
            choosenMenu = IO.IntIn("Välj ett alternativ: ");
            Console.ResetColor();

            switch (choosenMenu)
            {
                case 1:
                    isValidInput = true;
                    break;
                case 2:
                    isValidInput = true;
                    break;
                case 9:
                    IO.Out("Hej då!", true);
                    Environment.Exit(0);
                    break;
            }
        }

        return choosenMenu;
    }

    public static void GameOver()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            IO.Out("Vill du starta om?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            var shouldRestart = IO.StringIn("[1] för att börja om, [2] för att avsluta ");
            Console.ResetColor();

            if (shouldRestart == "1")
            {
                Console.Clear();
                Game game = new Game();
                game.StartGame();
                break;
            }

            if (shouldRestart == "2")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                IO.Out($"Tack för att du spelade!");
                Environment.Exit(0);
            }
        }
    }
}