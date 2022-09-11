using TestDateFormat;
namespace Library.Tests;

public class DataFormatterTests
{

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectFormat()
    {
        var date = "12/03/2001";
        var expected = "2001-03-12";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
    }

    [Test]
    public void TestIncorrectFormat()
    {
        var date = "12/03/200001";
        var expected = "Invalid format";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
    
    }

    [Test]
    public void TestEmptyDate()
    {
        var date = "";
        var expected = "Date cannot be null";
        Assert.AreEqual(expected, DateFormatter.ChangeFormat(date));
    }
}