using app.domain.client;
using app.domain.groupe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.contrat
{
    public class Contrat
    {
        
        public int CACHET_OFFERT { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CONTRAT { get; set; }
      
        [Required]
        public DateTime DATE_PRESTATION { get; set; }

        [Required]
        public string HEURE_DEBUT { get; set; }

        [Required]
        public string HEURE_FIN { get; set; }

        [Required]
        [ForeignKey("ID_CLIENT")]
        public Client Client { get; set; }
        public int ID_CLIENT { get; set; }

        [Required]
        [ForeignKey("NOM_DU_GROUPE")]
        public Groupe Groupe { get; set; }
        public string NOM_DU_GROUPE { get; set; }
    }
}
