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
}
