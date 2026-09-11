using System;
using System.Collections.Generic;
using System.Text;

namespace Wettrennnen
{
    public abstract class Fahrzeug
    {
        protected double Geschwindigkeit = 0; //kmh
        protected double Position = 0; //km
        protected int Raeder;
        protected double Minutes = 0;
        protected double Maximalgeschwindigkeit = 0;

        public void bewege (double Minutes)
        {
            if (Geschwindigkeit != 0)
            {
                double t = Minutes / 60;
                double strecke = Geschwindigkeit * t;
                Position = Position + strecke;          // Position += Geschwindigkeit * 
            }        
        }

        public void SetzeGeschwindigkeit(double geschwindigkeit)
        {
            if (Maximalgeschwindigkeit >= geschwindigkeit)
            {
                Geschwindigkeit = geschwindigkeit;
                Console.WriteLine("Maximalgeschwindigkeit von " + Maximalgeschwindigkeit + " nicht überschritten, aktuelle Geschwindigkeit liegt bei " +Geschwindigkeit);   
            }
        }

        public double getMaxGeschwindigkeit()
        {
            return Maximalgeschwindigkeit;
        }

        public double GetPosition()
        {
            return Position;
        }
    }

    public class Fahrrad: Fahrzeug
    {
        public Fahrrad() //constructor
        {
            Raeder = 2;
            Maximalgeschwindigkeit = 20;
        }
    }

    public class Auto: Fahrzeug
    {
        public Auto()
        {
            Raeder = 4;
            Maximalgeschwindigkeit = 150;
        }
    }

    public class Rennwagen : Auto
    {
        public Rennwagen()
        {
            Maximalgeschwindigkeit = 220;
        }
    }

    public class Krankenwagen : Auto
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

    public class Flugzeug : Fahrzeug
    {
        protected double Verspaetung = 0;
        bool Fahrwerk = false;
        public Flugzeug()
        {
            Raeder = 3;
            Maximalgeschwindigkeit = 750;
        }

        public void FahrwerkEingefahren()
        {
            Fahrwerk = false;
        }

        public void FahrwerkAusgefahren()
        {
            Fahrwerk = true;
        }

        public double setzeVerspaetung(double Verspeateung)
        {
            Minutes += Verspaetung;
            return Verspaetung;
        }
    }

}
