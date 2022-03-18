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

            player = new Player(name, 20, Items.Weapons[0]);

            new RoundOne(player).StartRound();
            Console.Clear();
            new RoundTwo(player).StartRound();
        }
    }

    private int printMenu()
    {
        int choosenMenu = 0;
        bool isValidInput = false; // Keep while loop running
        
        while (!isValidInput)
        {
            IO.Out("--- Välkommen till RPG GAME ---");
            IO.Out("");
            IO.Out("1. Starta nytt spel");
            IO.Out("9. Avsluta");
            IO.Out("");

            choosenMenu = IO.IntIn("Välj ett alternativ: ");

            switch (choosenMenu)
            {
                case 1:
                    isValidInput = true;
                    break;
                case 2:
                    isValidInput = true;
                    break;
                case 9:
                    IO.Out("Hejdå!", true);
                    Environment.Exit(0);
                    break;
            }
        }

        return choosenMenu;
    }
}