using System;
using System.Collections.Generic;

namespace Domain
{
    [Serializable]
    public class Igra
    {
        public Igra()
        {
            Pogadjanja = new List<Pogadjanje>();
        }
        public int IgraID { get; set; }
        public DateTime Datum { get; set; }
        public string ZadtataKombinacija { get; set; }
        public int BrojPokusaja { get; set; }
        public string Rezultat { get; set; }
        public List<Pogadjanje> Pogadjanja { get; set; }
    }
}
