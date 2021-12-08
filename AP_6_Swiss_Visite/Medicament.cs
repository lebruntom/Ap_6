using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    internal class Medicament
    {
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>();

        private string depotLegalMed;
        private string nomCommercialMed;
        private string familleCode;
        private string compositionMed;
        private string effetMed;
        private string contreIndicationMed;
        private float prixEchantillonMed;
        private int derniereEtape;

        public Medicament(string depotLegalMed, string nomCommercialMed, string familleCode, string compositionMed, string effetMed, string contreIndicationMed, float prixEchantillonMed, int derniereEtape)
        {
            this.depotLegalMed = depotLegalMed;
            this.nomCommercialMed = nomCommercialMed;
            this.familleCode = familleCode;
            this.compositionMed = compositionMed;
            this.effetMed = effetMed;
            this.contreIndicationMed = contreIndicationMed;
            this.prixEchantillonMed = prixEchantillonMed;
            this.derniereEtape = derniereEtape;
            lesMedicaments.Add(depotLegalMed, this);
        }
    }
}
