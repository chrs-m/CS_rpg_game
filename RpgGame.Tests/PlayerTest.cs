using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpgGame.Service;

namespace RpgGame.Tests;

[TestClass]
public class PlayerTest
{
    [TestMethod]
    public void Consume_PlayerEatsFood_HpIsAdded()
    {
        Player player = new Player("Test player", 10, new Weapon("Test weapon", 1, "", 0), 0);
        Food food = new Food("Test food", 10);

        player.Consume(food);
        
        Assert.AreEqual(player.Hp, 20);
    }

    [TestMethod]
    public void Consume_PlayerEatsFoodWithNegativeModifier_HpIsRemoved()
    {
        Player player = new Player("Test player", 10, new Weapon("Test weapon", 1, "", 0), 0);
        Food food = new Food("Test food", -10);
        
        player.Consume(food);
        
        Assert.AreEqual(player.Hp, 0);
    }

    [TestMethod]
    public void GetCoins_PlayerGetsCoins_CoinsAreAdded()
    {
        Player player = new Player("Test player", 10, new Weapon("Test weapon", 1, "", 0), 0);
        Coins coins = new Coins("test coins", 10);
        
        player.GetCoins(coins);
        
        Assert.AreEqual(player.Coins, 10);
    }
}