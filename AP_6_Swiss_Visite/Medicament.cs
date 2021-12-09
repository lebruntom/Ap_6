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
        private Famille laFamille;
        private string compositionMed;
        private string effetMed;
        private string contreIndicationMed;
        private float prixEchantillonMed;
        private int derniereEtape;

        public Medicament(string depotLegalMed, string nomCommercialMed, string laFamille, string compositionMed, string effetMed, string contreIndicationMed, float prixEchantillonMed, int derniereEtape)
        {
            this.depotLegalMed = depotLegalMed;
            this.nomCommercialMed = nomCommercialMed;
            this.laFamille = Famille.LesFamilles[laFamille];
            this.compositionMed = compositionMed;
            this.effetMed = effetMed;
            this.contreIndicationMed = contreIndicationMed;
            this.prixEchantillonMed = prixEchantillonMed;
            this.derniereEtape = derniereEtape;
            lesMedicaments.Add(depotLegalMed, this);
        }

        public string getDepotLegal() { return this.depotLegalMed; }

        public string getNomCommercial() { return this.nomCommercialMed; }

        public Famille getlaFamille() { return this.laFamille; }

        public string getComposition() { return this.compositionMed; }

        public string getEffet() { return this.effetMed; }

        public string getContreIndication() { return this.contreIndicationMed; }

        public float getPrixEchantillon() { return this.prixEchantillonMed; }

        public int getDerniereEtape() { return this.derniereEtape; }
    }
}
