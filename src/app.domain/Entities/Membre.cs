using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.domain.groupe;
using app.domain.artiste;

namespace app.domain.membre
{
    public class Membre
    {
        [Key]
        [Required]
        public string ROLE { get; set; }

        [ForeignKey("NOM_DU_GROUPE")]
        public Groupe Groupe { get; set; }
        public string NOM_DU_GROUPE { get; set; }

        [ForeignKey("ID_ARTISTE")]
        public Artiste Artiste { get; set; }
        public int ID_ARTISTE { get; set; }
    }
}
