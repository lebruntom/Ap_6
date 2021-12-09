<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    class Famille
    {
        private char code;
        private string libelle;
        private int nbMediAmm;



        public Famille(char code, string libelle, int nbMediAmm)
        {
            this.code = code;
            this.libelle = libelle;
            this.nbMediAmm = nbMediAmm;
        }



        public char getCode() { return this.code; }
        public string getLibelle() { return this.libelle; }
        public int getNbMediAmm() { return this.nbMediAmm; }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    internal class Famille
    {
        public static Dictionary<string, Famille> LesFamilles = new Dictionary<string, Famille>();

        private string codeFamille;
        private string libelleFamille;

        public Famille(string codeFamille, string libelleFamille)
        {
            this.codeFamille = codeFamille;
            this.libelleFamille = libelleFamille;
            LesFamilles.Add(codeFamille, this);
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
>>>>>>> romain
