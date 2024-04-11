using NUnit.Framework;

public class HeathTest
{
    [Test]
    [TestCase(5)]
    [TestCase(50)]
    [TestCase(100)]
    [TestCase(150)]
    public void Health_SetCurrentHealth(int hpAmountToSet) //Check current HP
    {
        var health = new Health();
        health.SetCurrentHp(hpAmountToSet);
        Assert.IsTrue(health.currentHp == hpAmountToSet);
    }

    [Test]
    [TestCase(5)]
    [TestCase(50)]
    [TestCase(100)]
    public void Health_SubtractHealth(int hpAmountToSubtract) 
    {
        var health = new Health();
        health.SetCurrentHp(health.startingHp);
        health.SubtractHp(hpAmountToSubtract);
        Assert.IsTrue(health.currentHp == (health.startingHp - hpAmountToSubtract));
    }

    [Test]
    [TestCase(5,5)]
    [TestCase(5,6)]
    [TestCase(100,9001)]
    public void Health_DoesNotGoBelowZero(int startingHp, int hpAmountToSubtract) 
    {
        var health = new Health();
        health.SetCurrentHp(startingHp);
        health.SubtractHp(hpAmountToSubtract);
        Assert.IsTrue(health.currentHp == 0);
    }

    [Test]
    [TestCase(5, 6)]
    [TestCase(5, 7)]
    [TestCase(4, 5)]
    public void Health_AddHealth(int startingHp, int hpAmountToAdd)
    {
        var health = new Health();
        health.SetCurrentHp(startingHp);
        health.AddHp(hpAmountToAdd);
        Assert.IsTrue(health.currentHp == (startingHp + hpAmountToAdd));
    }

    [Test]
    [TestCase(10, 91)]
    [TestCase(50, 60)]
    [TestCase(99, 9001)]
    public void Health_DoesNotGoAboveMax(int startingHp, int hpAmountToAdd)
    {
        var health = new Health();
        health.SetCurrentHp(startingHp);
        health.AddHp(hpAmountToAdd);
        Assert.IsTrue(health.currentHp == health.maxHp);
    }


}
