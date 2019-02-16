using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projekt___Matej_Miholjek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            const int brRedaka = 6;
            int selektor = 0;
            bool validator = false;
            while (selektor != brRedaka)
            {
                Console.Clear();
                Meni();
                Console.WriteLine("Odabir (1. - 6.): ");
                validator = int.TryParse(Console.ReadLine(), out selektor);

                if (validator)
                {
                    switch (selektor)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        default:
                            if (selektor != brRedaka)
                            {
                                ErrorMessage();
                            }
                            break;
                    }
                }
                else
                {
                    ErrorMessage();
                }
                Console.ReadKey();
            }

        }
        public static void ErrorMessage()
        {
            Console.WriteLine("Pogrešan unos! ");
        }
        public static void Meni()
        {
            Console.WriteLine("1. Dodavanje novog vozila");
            Console.WriteLine("2. Ažuriranje postojećeg vozila");
            Console.WriteLine("3. Ispis svih vozila");
            Console.WriteLine("4. Ispis vozila sa važećom registacijom");
            Console.WriteLine("5. Ispis vozila sa isteklom registracijom");
            Console.WriteLine("6. Prekid rada programa");
        }
        public static Vozilo dodavanjeVozila()
        {
            Console.WriteLine("Unesite marku vozila: ");
            string markaVozila = Console.ReadLine();

            Console.WriteLine("Unesite model vozila: ");
            string modelVozila = Console.ReadLine();

            Vozilo vozilo = new Vozilo(markaVozila, modelVozila);
            return vozilo;
        }
        public static void ispisVozila(List<Vozilo> vozila)
        {
            if (vozila.Count != 0)
            {
                foreach (Vozilo vozilo in vozila)
                {
                    Console.WriteLine("Marka vozila: {0} Model vozila: {1} Registracija oznaka vozila: {2}",
                        vozilo.MarkaVozila, vozilo.ModelVozila, vozilo.RegistarskaOznaka);
                    Console.WriteLine("Datum izdavanja registarske oznake: {0} Datum isteka registracije: {1}",
                        vozilo.DatumIzdavanjaRegistracije, vozilo.DatumIstekaRegistracije);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Nema unesenih vozila! ");
            }
        }
    }
}
