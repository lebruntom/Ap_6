using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    public class Etape_norme : Etape //heritage avec Etape
    {

        private int num;
        private string norme;
        private DateTime date;

        //pour récuperer avec : base les variables de la class Etape
        public Etape_norme(int etapeNum, string etapeLibelle, string norme, DateTime date) : base(etapeNum, etapeLibelle)
        {
            //on indique ici les choses unique qui ne sont pas dans Etape donc ici la norme et la date 
            this.norme = norme;
            this.date = date;
        }
        public int getNum() { return this.num; }
        public string getNorme() { return this.norme; }

        public DateTime GetDate() { return this.date; }

        //setters
        public void setNum(int num) { this.num = num; }
        public void setNorme(string norme) { this.norme = norme; }
        public void setdate(DateTime date) { this.date = date; }
    }
}
