using Xunit;

namespace Wettrennnen.Tests;

public class FahrzeugTests
{
    [Fact]
    public void Fahrrad_BewegtSichNachGeschwindigkeit()
    {
        var fahrrad = new Fahrrad();
        fahrrad.SetzeGeschwindigkeit(20);

        fahrrad.bewege(60);

        Assert.Equal(20, fahrrad.GetPosition(), 3);
    }

    [Fact]
    public void Auto_BewegtSichNachGeschwindigkeit()
    {
        var auto = new Auto();
        auto.SetzeGeschwindigkeit(150);
    
        auto.bewege(60);
    
        Assert.Equal(150, auto.GetPosition(), 3);
    }
}
