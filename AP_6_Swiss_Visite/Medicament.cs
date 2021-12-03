﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    class Medicament
    {
        private string depotLegal;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndications;
        private string amm;
        private int derniereEtape;
        private List<Famille> famille;
        //famille



        public Medicament(string depotLegal, string nomCommercial, string composition, string effets, string contreIndications, string amm, int derniereEtape, List<Famille> famille)
        {
            this.depotLegal = depotLegal;
            this.nomCommercial = nomCommercial;
            this.composition = composition;
            this.effets = effets;
            this.contreIndications = contreIndications;
            this.amm = amm;
            this.derniereEtape = derniereEtape;
            this.famille = famille;
        }



        public string getDepotLegal() { return this.depotLegal; }
        public string getNomCommercial() { return this.nomCommercial; }
        public string getComposition() { return this.composition; }
        public string getEffets() { return this.effets; }
        public string getContreIndications() { return this.contreIndications; }
        public string getAmm() { return this.amm; }
        public int getDerniereEtape() { return this.derniereEtape; }
        public List<Famille> getFamille() { return this.famille; }
    }
}