using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.contrat
{
    public class Contrat : Entity
    {
        public DateTime DATE_PRESTATION { get; set; }
        public string HEURE_DEBUT { get; set; }
        public string HEURE_FIN { get; set; }
        public int CACHET_OFFERT { get; set; }
    }
}
