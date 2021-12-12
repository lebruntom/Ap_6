using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Etape
    {
        public static List<Etape> lesEtapes = new List<Etape>();
        private List<EtapeNormee> lesEtapesNormees;
        private int numEtape;
        private string libelleEtape;

        public Etape(int leNumEtape, string leLibelleEtape)
        {
            this.numEtape = leNumEtape;
            this.libelleEtape = leLibelleEtape;
            this.lesEtapesNormees = new List<EtapeNormee>();
        }

        public int getNumEtape()
        {
            return this.numEtape;
        }

        public string getLibelleEtape()
        {
            return this.libelleEtape;
        }

        public List<EtapeNormee> GetLesEtapeNormees()
        {
            return this.lesEtapesNormees;
        }
    }
}
