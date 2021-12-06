using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Famille
    {
        private string code;
        private string libelle;
        private int nbMediAmm;



        public Famille(string code, string libelle, int nbMediAmm)
        {
            this.code = code;
            this.libelle = libelle;
            this.nbMediAmm = nbMediAmm;
        }



        public string getCode() { return this.code; }
        public string getLibelle() { return this.libelle; }
        public int getNbMediAmm() { return this.nbMediAmm; }
    }
}
