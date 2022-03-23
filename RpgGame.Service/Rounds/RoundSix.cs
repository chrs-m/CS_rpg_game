namespace RpgGame.Service.Rounds;

public class RoundSix : Round
{
    public int RoundNum { get; }
    public string RoundType { get; }

    private Player Player;

    public RoundSix(Player player)
    {
        Player = player;
    }

    public override void StartRound()
    {
        Console.ResetColor();
        while (true)
        {
            IO.Out("Du har hittat en shop, vill du gå in?");
            IO.Out("[1] ja -- [2] nej, gå vidare");
            int choosen = IO.IntIn("Gör ditt val: ");

            if (choosen == 1)
            {
                StartShop();
                break;
            }

            if (choosen == 2)
            {
                IO.Out("Du går förbi shoppen och fortätter på ditt äventyr.");
                break;
            }
        }
    }

    private void StartShop()
    {
        Console.Clear();

        while (true)
        {
            IO.Out("Vad vill du köpa?");
            IO.Out($"Du har {Player.Coins}kr att nyttja");
            IO.Out("[1] Mat -- [2] Vapen ");
            int choosen = IO.IntIn("Gör ditt val: ");

            if (choosen == 1)
            {
                Console.Clear();
                FoodShop();
                break;
            }
            
            if (choosen == 2)
            {
                Console.Clear();
                WeaponShop();
                break;
            }
        }
        
        IO.Out("Du går ut från shoppen och fortsätter på ditt äventyr.");
    }

    private void FoodShop()
    {
        var BuyableFood = Items.Food.Where(food => food.Price != null).ToArray();

        Console.Clear();
        IO.Out("");
        int index = 1;
        foreach (var food in BuyableFood)
        {
            IO.Out($"{index}. {food.Name}");
            IO.Out($"   Pris: {food.Price}kr");
            IO.Out($"   Ger: {food.Modifier}hp");
            IO.Out("");
            index++;
        }

        while (true)
        {
            IO.Out($"Du har {Player.Coins}kr");
            int choosen = IO.IntIn($"Välj en produkt (1 - {index}): ");

            if (choosen > 0 && choosen <= index)
            {
                Food wantsToBuy = BuyableFood[choosen - 1];

                if (Player.Coins >= wantsToBuy.Price)
                {
                    Console.Clear();
                    IO.Out($"Du har köpt och förtärt en {wantsToBuy.Name}");
                    Player.Consume(wantsToBuy);
                    IO.Out($"Du har nu {Player.Hp}hp");
                }
                else
                {
                   IO.Out($"Du har inte råd med {wantsToBuy.Name}. Du saknar {wantsToBuy.Price - Player.Coins}kr"); 
                }

                break;
            }
        }

        while (true)
        {
            IO.Out("Vill du forstätta handla?");
            var choosen = IO.IntIn("[1] ja -- [2] nej ");

            if (choosen == 1)
            {
                Console.Clear();
                StartShop();
            }
            
            if (choosen == 2)
            {
                break;
            }
        }

    }

    private void WeaponShop()
    {
        var BuyableWeapon = Items.Weapons.Where(weapon => weapon.Price != null).ToArray();
        
        Console.Clear();
        IO.Out("");
        int index = 1;
        foreach (var weapon in BuyableWeapon)
        {
            IO.Out($"{index}. {weapon.Name}");
            IO.Out($"   Pris: {weapon.Price}kr");
            IO.Out($"   Ger: {weapon.Damage}dmg");
            IO.Out("");
            index++;
        }

        while (true)
        {
            IO.Out($"Du har {Player.Coins}kr");
            int choosen = IO.IntIn($"Välj en produkt (1 - {index}): ");
            Console.Clear();

            if (choosen > 0 && choosen <= index)
            {
                Weapon wantsToBuy = BuyableWeapon[choosen - 1];

                if (Player.Coins >= wantsToBuy.Price)
                {
                    Console.Clear();
                    IO.Out($"Du har köpt {wantsToBuy.Name}, lycka till i nästa strid");
                    Player.Weapon = wantsToBuy;
                }
                else
                {
                    IO.Out($"Du har inte råd med {wantsToBuy.Name}. Du saknar {wantsToBuy.Price - Player.Coins}kr"); 
                }

                break;
            }
        }

        while (true)
        {
            IO.Out("Vill du forstätta handla?");
            var choosen = IO.IntIn("[1] ja -- [2] nej ");
            Console.Clear();

            if (choosen == 1)
            {
                StartShop();
            }
            
            if (choosen == 2)
            {
                break;
            }
        }
    }

}