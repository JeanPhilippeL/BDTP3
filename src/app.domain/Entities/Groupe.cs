using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.domain.membre;

namespace app.domain.groupe
{
    public class Groupe
    {
        
        public string CACHET_SOUHAITER { get; set; }

        [Key]
        public string NOM_DU_GROUPE { get; set; }
    }
}
