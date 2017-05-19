using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.domain.client
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CLIENT { get; set; }

        [Required]
        public string NOM_CLIENT { get; set; }

        [Required]
        public string TELEPHONE_CLIENT { get; set; }

        public string REFERENCE { get; set; }
    }
}
