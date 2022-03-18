using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RpgGame.Service;
using RpgGame.Service.Rounds;

namespace RpgGame.Tests;

[TestClass]
public class RoundOneTests
{
    [TestMethod]
    public void StartRound_PlayerGetsHp_HpIsAdded()
    {
        Player player = new Player("Test player", 20, new Weapon("", 0, ""));
        
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var stringReader = new StringReader("1");
        Console.SetIn(stringReader);

        RoundOne round = new RoundOne(player);
        round.StartRound();

        Assert.AreEqual(23, player.Hp);
    }
}