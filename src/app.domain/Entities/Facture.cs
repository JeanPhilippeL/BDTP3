using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain.facture
{
    public class Facture : Entity
    {
        [Key]
        public string ID_FACTURE { get; set; }

        public DateTime DATE_DE_PRODUCTION { get; set; }
    }
}
