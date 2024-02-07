using Domain;
using System;

namespace AppLogic
{
    public class Controller
    {
        private static Controller instance;
        private Controller() { }
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }

        public Response Pogadjanje(Pogadjanje pogadjanje, int[] dobitnaKombinacija)
        {
            Response r = new Response();
            bool[] pogodjeniNaMestu = new bool[4];
            bool[] pogodjeniNISUNaMestu = new bool[4];

            for (int i = 0; i < pogadjanje.Cifre.Length; i++)
            {
                if (pogadjanje.Cifre[i] == dobitnaKombinacija[i])
                {
                    pogodjeniNaMestu[i] = true;
                    pogadjanje.BrojPogodjenihNaMestu++;
                }
            }

            if(pogadjanje.BrojPogodjenihNaMestu == 4)
            {
                r.IsSuccesful = true;
                r.ResponseObject = pogadjanje;
                return r;
            }

            for (int i = 0; i < pogadjanje.Cifre.Length; i++)
            {
                if (!pogodjeniNaMestu[i])
                {
                    for (int j = 0; j < pogadjanje.Cifre.Length; j++)
                    {
                        if (pogadjanje.Cifre[j] == dobitnaKombinacija[i] && !pogodjeniNaMestu[j] && !pogodjeniNISUNaMestu[j])
                        {
                            pogodjeniNISUNaMestu[j] = true;
                            pogadjanje.BrojPogodjenihNISUNaMestu++;
                            break;
                        }
                    }
                }
            }
            r.ResponseObject = pogadjanje;
            return r;
        }
    }
}
