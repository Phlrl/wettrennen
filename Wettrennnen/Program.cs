using System.Globalization;

namespace Wettrennnen
{
    class Wettrennen
    {
        static void Main(string[] args)
        {
            Fahrrad fahrrad = new Fahrrad();
            fahrrad.SetzeGeschwindigkeit(20);

            Auto auto= new Auto();
            auto.SetzeGeschwindigkeit(150);

            Rennwagen rennwagen = new Rennwagen();
            rennwagen.SetzeGeschwindigkeit(200);

            Krankenwagen krankenwagen = new Krankenwagen();
            krankenwagen.SetzeGeschwindigkeit(80);

            fahrrad.bewege(240);

            fahrrad.bewege(60);

            auto.bewege(60);

            rennwagen.bewege(60);

            krankenwagen.bewege(60);
        }
    }
}

