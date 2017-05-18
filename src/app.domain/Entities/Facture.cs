using app.domain.contrat;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.facture
{
    public class Facture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CLEINT { get; set; }

        [Required]
        public DateTime DATE_DE_PRODUCTION { get; set; }

        [ForeignKey("ID_CONTRAT")]
        public Contrat Contrat { get; set; }
        public int ID_CONTRAT { get; set; }
    }
}
