using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Etape
    {
        private int etapeNum;
        private string etapeLibelle;
        private List<Etape_norme> lesEtapesNormees;

        public Etape(int etapeNum, string etapeLibelle)
        {
            this.etapeNum = etapeNum;
            this.etapeLibelle = etapeLibelle;
            this.lesEtapesNormees = new List<Etape_norme>();
        }

        public int getEtapeNum() => etapeNum;
        public string getEtapeLibelle() => etapeLibelle;

        public void getEtapeNum(int etapeNum) { this.etapeNum = etapeNum; }
        public void getEtapeLibelle(string etapeLibelle) { this.etapeLibelle = etapeLibelle; }
        public List<Etape_norme> getLesEtapesNormees() { return this.lesEtapesNormees; }

    }
}
