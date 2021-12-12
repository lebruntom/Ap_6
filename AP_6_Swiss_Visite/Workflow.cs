using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Workflow
    {
        private string depotLegalWorkflow;
        private int etapeNum;
        private int decisionID;
        private DateTime dateDecision;
        public static List<Workflow> lesWorkflows = new List<Workflow>();

        public Workflow(string ledepotLegalWorkflow, int etapeNum, int decisionID, DateTime dateDecision)
        {
            this.depotLegalWorkflow = ledepotLegalWorkflow;
            this.etapeNum = etapeNum;
            this.decisionID = decisionID;
            this.dateDecision = dateDecision;
            lesWorkflows.Add(this);
        }
        public string getDepotLegalWorkflow() { return this.depotLegalWorkflow;  }
        public int getEtapeNum() { return this.etapeNum; }
        public int getDecisionID() { return this.decisionID; }
        public DateTime getDateDecision() { return this.dateDecision; }

    }
}
