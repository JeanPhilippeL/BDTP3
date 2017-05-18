using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.domain.groupe
{
    public class Groupe
    {
        [Key]
        public string NOM_DU_GROUPE { get; set; }
    }
}
