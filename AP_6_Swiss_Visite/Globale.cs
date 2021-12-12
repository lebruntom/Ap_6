using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_6_Swiss_Visite
{
    class Globale
    {
        public static List<Etape> lesEtapes = new List<Etape>();
        public static List<Etape_norme> norme = new List<Etape_norme>();
        public static List<Decision> LesDecisions = new List<Decision>();
        public static Dictionary<string, Famille> LesFamilles = new Dictionary<string, Famille>();
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>();
    }
}
