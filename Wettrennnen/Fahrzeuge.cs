using System;
using System.Collections.Generic;
using System.Text;

namespace Wettrennnen
{
    abstract class Fahrzeug
    {
        protected double Geschwindigkeit = 0; //kmh
        protected double Position = 0; //km


        protected void bewege (double Minutes)
        {
            double t = Minutes / 60;
            Position += Geschwindigkeit * t;
        }

        protected void SetzeGeschwindigkeit()
        {

        }
        protected int Raeder;
    }

    class Fahrrad: Fahrzeug
    {
        public Fahrrad()
        {
            Raeder = 2;

            Fahrrad fahrrad = new Fahrrad();
        }
    }

    class Auto: Fahrzeug
    {
        public Auto()
        {
            Raeder = 4;
            Auto auto = new Auto();
        }
    }

    class Rennwagen : Auto
    {
        
    }

    class Krankenwagen : Auto
    {

    }
}
