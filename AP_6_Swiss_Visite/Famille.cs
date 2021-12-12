using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Famille
    {

        private string codeFamille;
        private string libelleFamille;

        public Famille(string lecodeFamille, string lelibelleFamille)
        {
            this.codeFamille = lecodeFamille;
            this.libelleFamille = lelibelleFamille;
            Globale.LesFamilles.Add(codeFamille, this);
        }

        public string getCodeFamille()
        {
            return this.codeFamille;
        }

        public string getLibelleFamille()
        {
            return this.libelleFamille;
        }
    }
}
