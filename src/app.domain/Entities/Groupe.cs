using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.domain.membre;

namespace app.domain.groupe
{
    public class Groupe
    {
        
        public int CACHET_SOUHAITER { get; set; }

        [Key]
        public string NOM_DU_GROUPE { get; set; }
    }
}
