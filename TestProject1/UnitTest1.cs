namespace TestProject1;
using ConsoleApp1;
public class Tests
{
    [Test]
    public void MinFromTwoNumbersTest()
    {
        Assert.IsTrue(ConsoleApp1.Program.MinFromTwoNumbers(5, 2));
        Assert.IsFalse(ConsoleApp1.Program.MinFromTwoNumbers(2,5));
    }
    [Test]
    public void MetersToCentimeters()
    {
        Assert.That(ConsoleApp1.Program.MetersToCentimeters(5),Is.EqualTo(500));
        Assert.That(ConsoleApp1.Program.MetersToCentimeters(6), Is.EqualTo(600));
    }
    [Test]
    public void AuthorizationMetod1()
    {
        Assert.IsTrue(ConsoleApp1.Program.AuthorizationMetod1("mukha","sanya"));
        Assert.IsFalse(ConsoleApp1.Program.AuthorizationMetod1("","sa"));

    }
    [Test]
    public void AuthorizationMetod2()
    {
       Assert.IsTrue(ConsoleApp1.Program.AuthorizationMetod2("mukha","sanya","mukhakirill@gmail.com","22.02.2003"));
       Assert.IsFalse(ConsoleApp1.Program.AuthorizationMetod2("mukha","sanya","mukhakirillgmail.com","30.02.2003")); 

    }
    [Test]
    public void TestDate()
    {
        Assert.IsTrue(ConsoleApp1.Program.TestDate("30.05.2023"));
        Assert.IsFalse(ConsoleApp1.Program.TestDate("32.05.2023"));

    }
}