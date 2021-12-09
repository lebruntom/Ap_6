using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    class Etape
    {
        private int etapeNum;
        private string etapeLibelle;

        public Etape(int etapeNum, string etapeLibelle)
        {
            this.etapeNum = etapeNum;
            this.etapeLibelle = etapeLibelle;
        }

        public int getEtapeNum() => etapeNum;
        public string getEtapeLibelle() => etapeLibelle;

        public void getEtapeNum(int etapeNum) { this.etapeNum = etapeNum; }
        public void getEtapeLibelle(string etapeLibelle) { this.etapeLibelle = etapeLibelle; }

    }
}
