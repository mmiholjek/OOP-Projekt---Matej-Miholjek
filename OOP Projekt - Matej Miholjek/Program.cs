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

                            }
                            break;
                    }
                }
                else
                {

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
    }
}
