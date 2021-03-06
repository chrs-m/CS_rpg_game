using System.Runtime.CompilerServices;

namespace RpgGame.Service;

public class Items
{
    public static List<Weapon> Weapons = new List<Weapon>()
    {
        new Weapon("Trasig käpp", 5, "Kundvagns-Kristers gammla käpp.", 5),
        new Weapon("Slipat pingisracket", 10, "Ett mycket välanvänt racket som fått lite vassare kanter.", 15),
        new Weapon("Baseballträ", 20, "Standard baseboll trä, stulet från Stadium.", 35),
        new Weapon("T-Kors", 30, "Prima T-kors, stulet från Biltema.", 50),
        new Weapon("Farfars gamla värja", 100,
            "Gått i arv i flera generationer, sägs ha varit med sedan slaget vid Uddevalla ano 1677.", 0)
    };

    public static List<Food> Food = new List<Food>()
    {
        new Food("Halväten Biltemakorv", 3),
        new Food("Möglig hamburgare", -6),
        new Food("Falcon långburk", 8, 11),
        new Food("Snigel", 15),
        new Food("Grillad Kyckling", 30, 15),
        new Food("Dunk hembränt", -100, 5),
        new Food("Calzone med extra bea", 40, 40),
        new Food("Halv special", 20, 15),
        new Food("Kotte", 2, 1),
        new Food("Smutsig hönökaka", -3),
        new Food("Utspottad lössnus", -10)
    };

    public static List<Coins> Coins = new List<Coins>()
    {
        new Coins("trasig myntbörs", 0),
        new Coins("liten myntbörs", 15),
        new Coins("lagom stor myntbörs, aka Svensson-börs", 35),
        new Coins("stor myntbörs", 50),
    };

    public static List<Enemy> Enemies = new List<Enemy>();
}