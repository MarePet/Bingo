using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Pogadjanje
    {
        public int RB { get; set; }
        public string Kombinacija { get; set; } 
        public int[] Cifre { get; set; } 
        public int BrojPogodjenihNaMestu { get; set; }
        public int BrojPogodjenihNISUNaMestu { get; set; }
    }
}
