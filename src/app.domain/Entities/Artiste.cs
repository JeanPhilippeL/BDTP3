using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.artiste
{
    public class Artiste
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_ARTISTE { get; set; }

        [Required]
        public string NOM_ARTISTE { get; set; }

        [Required]
        public string PRENOM_ARTISTE { get; set; }

        [Required]
        public string TELEPHONE { get; set; }
        
        public string NOM_DE_SCENE { get; set; }

        [Required]
        public long NAS { get; set; }
    }
}
