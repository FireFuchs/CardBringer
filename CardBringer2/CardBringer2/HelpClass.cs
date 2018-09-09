using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2
{

    static class HelpClass
    {
        public static int TrenutnaForma = 0;
        private static readonly IDictionary<int, string> tekstoviHelpa = new Dictionary<int, string>()
        {
            {0,
                $"Nije naveden tekst helpa za ovu formu" },


            // Administracija
            {1,
                $"Administracija" },

            // Kosarica
            {2,
                $"Kosarica" },

            // ListaZelja
            {3,
                $"ListaZelja" },

            // LoginRegisterForma
            {4,
                $"LoginRegisterForma" },

            // MojeKupnje
            {5,
                $"MojeKupnje" },

            // MojProfil
            {6,
                $"MojProfil" },

            // NovaKartaAdmin
            {7,
                $"NovaKartaAdmin" },

            //ObjaviOglas
            {8,
                $"ObjaviOglas" },

            // Pocetna
            {9,
                $"Pocetna" },

            // PromjenaUlogeKorisnika
            {10,
                $"PromjenaUlogeKorisnika" }
        };


        public static string DohvatiHelpTekst()
        {
            return tekstoviHelpa[TrenutnaForma];
        }

    }

}
