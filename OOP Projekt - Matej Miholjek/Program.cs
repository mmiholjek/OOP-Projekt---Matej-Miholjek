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
                Console.Write("Odabir (1. - 6.): ");
                validator = int.TryParse(Console.ReadLine(), out selektor);

                if (validator)
                {
                    switch (selektor)
                    {
                        case 1:
                            vozila.Add(dodavanjeVozila());
                            break;
                        case 2:
                            izmjenaVozila(vozila, odabirVozila(vozila));
                            break;
                        case 3:
                            ispisVozila(vozila);
                            break;
                        case 4:
                            vazeceRegistracije(vozila);
                            break;
                        case 5:
                            istekleRegistracije(vozila);
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
        public static int odabirVozila(List<Vozilo> vozila)
        {
            if (vozila.Count != 0)
            {
                int brojUListi = 1;
                foreach (Vozilo vozilo in vozila)
                {
                    Console.WriteLine("{0}. Vozilo: {1}, {2}", brojUListi, vozilo.MarkaVozila, vozilo.ModelVozila);
                    brojUListi++;
                }
                Console.Write("Unesite vozilo koje želite promjeniti: ");
                int unos;
                int.TryParse(Console.ReadLine(), out unos);
                int index = unos - 1;
                return index;
            }
            else
            {
                Console.WriteLine("Nema unesenih vozila! ");
                return 0;
            }
        }
        public static void izmjenaVozila(List<Vozilo> vozila, int index)
        {
            Console.Write("Unesite novu marku vozila: ");
            string markaVozila = Console.ReadLine();

            Console.Write("Unesite novi model vozila: ");
            string modelVozila = Console.ReadLine();

            Console.Write("Unesite registraciju vozila: ");
            string registracijaVozila = Console.ReadLine();

            Console.Write("Unesite datum izdavanja registracije(YYYY.MM.DD.): ");
            DateTime datumIzdvanjaRegistracije = DateTime.Parse(Console.ReadLine());

            Console.Write("Unesite datum isteka registracije(YYYY.MM.DD.): ");
            DateTime datumIstekaRegistracije = DateTime.Parse(Console.ReadLine());

            vozila[index].MarkaVozila = markaVozila;
            vozila[index].ModelVozila = modelVozila;
            vozila[index].RegistarskaOznaka = registracijaVozila;
            vozila[index].DatumIzdavanjaRegistracije = datumIzdvanjaRegistracije;
            vozila[index].DatumIstekaRegistracije = datumIstekaRegistracije;
        }
        public static void vazeceRegistracije(List<Vozilo> vozila)
        {
            if (vozila.Count != 0)
            {
                foreach (Vozilo vozilo in vozila)
                {
                    if (vozilo.DatumIstekaRegistracije > DateTime.Today)
                    {
                        Console.WriteLine("Ispis vozila sa važećom registacijom");
                        Console.WriteLine("Marka vozila: {0} Model vozila: {1} Registracija oznaka vozila: {2}",
                            vozilo.MarkaVozila, vozilo.ModelVozila, vozilo.RegistarskaOznaka);
                        Console.WriteLine("Datum izdavanja registarske oznake: {0} Datum isteka registracije: {1}",
                            vozilo.DatumIzdavanjaRegistracije, vozilo.DatumIstekaRegistracije);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Nema vozila u listi!");
            }
        }
        public static void istekleRegistracije(List<Vozilo> vozila)
        {
            if (vozila.Count != 0)
            {
                foreach (Vozilo vozilo in vozila)
                {
                    if (vozilo.DatumIstekaRegistracije < DateTime.Today)
                    {
                        Console.WriteLine("Ispis vozila sa isteklom registracijom");
                        Console.WriteLine("Marka vozila: {0} Model vozila: {1} Registracija oznaka vozila: {2}",
                            vozilo.MarkaVozila, vozilo.ModelVozila, vozilo.RegistarskaOznaka);
                        Console.WriteLine("Datum izdavanja registarske oznake: {0} Datum isteka registracije: {1}",
                            vozilo.DatumIzdavanjaRegistracije, vozilo.DatumIstekaRegistracije);
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Nema vozila u listi!");
            }
        }
    }
}
