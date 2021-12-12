using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    internal class Medicament
    {
        private List<Workflow> lesEtapes = new List<Workflow>();
        private string depotLegalMed;
        private string nomCommercialMed;
        private Famille laFamille;
        private string compositionMed;
        private string effetMed;
        private string contreIndicationMed;
        private float prixEchantillonMed;
        private int derniereEtape;

        public Medicament(string ledepotLegalMed, string lenomCommercialMed, string laFamille, string lecompositionMed, string leeffetMed, string lecontreIndicationMed, float leprixEchantillonMed, int lederniereEtape)
        {
            this.depotLegalMed = ledepotLegalMed;
            this.nomCommercialMed = lenomCommercialMed;
            this.laFamille = Globale.LesFamilles[laFamille];
            this.compositionMed = lecompositionMed;
            this.effetMed = leeffetMed;
            this.contreIndicationMed = lecontreIndicationMed;
            this.prixEchantillonMed = leprixEchantillonMed;
            this.derniereEtape = lederniereEtape;
            Globale.lesMedicaments.Add(depotLegalMed, this);
        }

        public string getDepotLegal() { return this.depotLegalMed; }

        public string getNomCommercial() { return this.nomCommercialMed; }

        public Famille getlaFamille() { return this.laFamille; }

        public List<Workflow> getLesEtapes() { return this.lesEtapes; }

        public string getComposition() { return this.compositionMed; }

        public string getEffet() { return this.effetMed; }

        public string getContreIndication() { return this.contreIndicationMed; }

        public float getPrixEchantillon() { return this.prixEchantillonMed; }

        public int getDerniereEtape() { return this.derniereEtape; }

        public void setlesEtapes(List<Workflow> lesEtapes) { this.lesEtapes = lesEtapes;  }
    }
}
