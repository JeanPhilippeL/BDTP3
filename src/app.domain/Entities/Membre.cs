using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.domain.groupe;

namespace app.domain.membre
{
    public class Membre
    {
        [Key]
        [Required]
        public string ROLE { get; set; }
    }
}
