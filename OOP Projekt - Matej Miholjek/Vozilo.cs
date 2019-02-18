using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projekt___Matej_Miholjek
{
    class Vozilo
    {
        public string MarkaVozila { get; set; }
        public string ModelVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public DateTime? DatumIzdavanjaRegistracije { get; set; }
        public DateTime? DatumIstekaRegistracije { get; set; }

        public Vozilo(string markaVozila,string modelVozila)
        {
            this.MarkaVozila = markaVozila;
            this.ModelVozila = modelVozila;
        }
    }
}
