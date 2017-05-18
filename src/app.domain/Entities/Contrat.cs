using app.domain.client;
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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CONTRAT { get; set; }

        [Required]
        public DateTime DATE_PRESTATION { get; set; }

        [Required]
        public string HEURE_DEBUT { get; set; }

        [Required]
        public string HEURE_FIN { get; set; }

        public int CACHET_OFFERT { get; set; }

        [ForeignKey("ID_CLEINT")]
        public Client Client { get; set; }  //propriété de navigation
        public int ID_CLEINT { get; set; }

    }
}
