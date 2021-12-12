using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Decision
    { 

        public int id;
        public string libelle;

        public Decision(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
            Globale.LesDecisions.Add(this);
        }
        public int getID() { return this.id; }
        public string getLibelle() { return this.libelle; }

    }
}
