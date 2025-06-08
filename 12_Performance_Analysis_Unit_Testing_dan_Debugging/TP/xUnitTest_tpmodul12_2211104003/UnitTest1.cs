using Xunit;
using tpmodul12_2211104003;
using tpmodul12_2211104003ss;

public class BilanganHelperTests
{
    [Fact]
    public void TestNegatif()
    {
        Assert.Equal("Negatif", BilanganHelper.CariTandaBilangan(-3));
    }

    [Fact]
    public void TestPositif()
    {
        Assert.Equal("Positif", BilanganHelper.CariTandaBilangan(5));
    }

    [Fact]
    public void TestNol()
    {
        Assert.Equal("Nol", BilanganHelper.CariTandaBilangan(0));
    }
}

