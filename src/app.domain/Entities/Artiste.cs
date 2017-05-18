using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.artiste
{
    public class Artiste : Entity
    {
        public string NOM_ARTISTE { get; set; }
        public string PRENOM_ARTISTE { get; set; }
        public string TELEPHONE { get; set; }
        public string NOM_DE_SCENE { get; set; }
        public long NAS { get; set; }
    }
}
