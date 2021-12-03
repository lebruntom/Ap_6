using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    class Workflow
    {
        private DateTime dateDecision;
        private List<Etape> etape;
        private List<Decision> decision;



        public void workflow(DateTime dateDecision, List<Etape> etape, List<Decision> decision)
        {
            this.dateDecision = dateDecision;
            this.etape = etape;
            this.decision = decision;
        }
    }
}
