using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AP_6_Swiss_Visite
{
    class Globale
    {
        Dictionary<int, Famille> famille = new Dictionary<int, Famille>();
        Dictionary<string, Medicament> medicament = new Dictionary<string, Medicament>();
        public static List<Etape> lesEtapes = new List<Etape>();
        public static List<EtapeNormee> lesEtapesNormee = new List<EtapeNormee>();
        public static SqlConnection cnx;
    }
}
