using System.Globalization;

namespace Wettrennnen
{
    class Wettrennen
    {
        static void Main(string[] args)
        {
            test2();
            Console.WriteLine("ende");
        }

        static void test()
        {
            //in test werden fahrrad usw generiert und es wird mit der methode setze geschwindgkeit die geschwindigkeit gesetzt
            Fahrrad fahrrad = new Fahrrad();
            fahrrad.SetzeGeschwindigkeit(20);

            Auto auto = new Auto();
            auto.SetzeGeschwindigkeit(150);

            Rennwagen rennwagen = new Rennwagen();
            rennwagen.SetzeGeschwindigkeit(200);

            Krankenwagen krankenwagen = new Krankenwagen();
            krankenwagen.SetzeGeschwindigkeit(80);

            //dann wird jedes objekt mit der methode bewege bewegt und in () steht der wert in min

            fahrrad.bewege(240);

            fahrrad.bewege(60);

            auto.bewege(60);

            rennwagen.bewege(60);

            krankenwagen.bewege(60);
            krankenwagen.BlaulichtAn();
        }

        static void test2()
        {

            //list für alle farzeuge über den loop werden sie aus der liste gepullt und in die for each schleife gepacktg wo sie dann mit der methode bewege 1 h lang fahren.
            List<Fahrzeug> fahrzeuge = new List<Fahrzeug>();

            Fahrrad fahrrad = new Fahrrad();
            fahrrad.SetzeGeschwindigkeit(20);
            fahrzeuge.Add(fahrrad); //Addet zur list fahrzeuge
            fahrrad.bewege(240);

            Auto auto = new Auto();
            auto.SetzeGeschwindigkeit(150);
            fahrzeuge.Add(auto);

            Rennwagen rennwagen = new Rennwagen();
            rennwagen.SetzeGeschwindigkeit(200);
            fahrzeuge.Add(rennwagen);

            Krankenwagen krankenwagen = new Krankenwagen();
            krankenwagen.SetzeGeschwindigkeit(80);
            fahrzeuge.Add(krankenwagen);

            foreach (var fahrzeug in fahrzeuge)
            {
                fahrzeug.bewege(60);

                Console.WriteLine(fahrzeug.GetPosition());

                // fahrzeug.blaulichtAn(); geht nicht fahrzeug.blaulichtAn() nicht eine methode von der klasse fahrzeug ist sondern nur der klasse krankenwagen
            }


        }
    }
}

