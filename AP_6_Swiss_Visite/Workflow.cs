using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    class Workflow
    {
        private int etapeNum;
        private int decisionID;
        private DateTime dateDecision;
        private List<Etape> lesEtapes = new List<Etape>();

        public Workflow(int etapeNum, int decisionID, DateTime dateDecision)
        {
            this.etapeNum = etapeNum;
            this.decisionID = decisionID;
            this.dateDecision = dateDecision;
        }
        public int getEtapeNum() { return this.etapeNum; }
        public int getDecisionID() { return this.decisionID; }
        public DateTime getDateDecision() { return this.dateDecision; }

        public List<Etape> getListeEtape() { return this.lesEtapes; }
    }
}
