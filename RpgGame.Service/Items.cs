using System.Runtime.CompilerServices;

namespace RpgGame.Service;

public class Items
{
    public static List<Weapon> Weapons = new List<Weapon>()
    {
        new Weapon("Trasig käpp", 5, "Kundvagns-Kristers gammla käpp", 5),
        new Weapon("Slipat pingisracket", 10, "", 15),
        new Weapon("Baseballträ", 20, "", 35),
        new Weapon("T-Kors", 30, "", 50),
        new Weapon("Farfars gamla värja", 100, "", null)
    };
    
    public static List<Food> Food = new List<Food>()
    {
        new Food("Halväten Biltemakorv", 3),
        new Food("Möglig hamburgare", -4),
        new Food("Falcon långburk", 10),
        new Food("Snigel", 15),
        new Food("Grillad Kyckling", 30),
        new Food("Dunk hembränt", -15),
        new Food("Calzone med extra bea", 40)
    };
    
    public static List<Enemy> Enemies = new List<Enemy>()
    {
        new Enemy("Piss i huvet", 15, "enemy", new Weapon("Repstump", 3, $"En bit rep som 'Piss i huvet' tagit med sig från hamnen.", null)),
        new Enemy("Gissa mitt jobb", 30, "enemy", new Weapon("Vässat stolsben", 10, $"Efter slagsmål i hamnen så fick 'Gissa mitt jobb' med sig detta hem.", null)),
        new Enemy("Tjuven i Baghdad", 70, "boss", new Weapon("Shamshir stulen i Baghdad", 20, "Föremålet behöver ingen närmre beskrvining..", null))
    };
}