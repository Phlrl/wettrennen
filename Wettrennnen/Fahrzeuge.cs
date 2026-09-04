using System;
using System.Collections.Generic;
using System.Text;

namespace Wettrennnen
{
    abstract class Fahrzeug
    {
        protected double Geschwindigkeit = 0; //kmh

        protected double Position = 0; //km

        protected int Raeder;

        protected double Maximalgeschwindigkeit = 0;

        public void bewege (double Minutes)
        {
            double t = Minutes / 60;
            double strecke = Geschwindigkeit * t;
            Position = Position + strecke;          // Position += Geschwindigkeit * t
        }

        public void SetzeGeschwindigkeit(double geschwindigkeit)
        {
            if (Maximalgeschwindigkeit > geschwindigkeit)
            {
                Geschwindigkeit = geschwindigkeit;
                Console.WriteLine("Maximalgeschwindigkeit nicht überschritten");  // todo : einfügen von geschwindigkeit und max geschwindigkeit in protokoll 
            }
        }

        public double getMaxGeschwindigkeit()
        {
            return Maximalgeschwindigkeit;
        }
    }

    class Fahrrad: Fahrzeug
    {
        public Fahrrad() //constructor
        {
            Raeder = 2;
            Maximalgeschwindigkeit = 20;
        }
    }

    class Auto: Fahrzeug
    {
        public Auto()
        {
            Raeder = 4;
            Maximalgeschwindigkeit = 150;
        }
    }

    class Rennwagen : Auto
    {
        public Rennwagen()
        {
            Maximalgeschwindigkeit = 220;
        }
    }

    class Krankenwagen : Auto
    {
        bool Blaulicht = false;

        public Krankenwagen()
        {
            Maximalgeschwindigkeit = 80;
        }

        public void BlaulichtAn()
        {
            Blaulicht = true;
        }

        public void BlaulichtAus()
        {
            Blaulicht = false;
        }
    }
}
