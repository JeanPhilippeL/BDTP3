﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using app.domain.membre;

namespace app.domain.groupe
{
    public class Groupe
    {
        [Key]
        public string CACHET_SOUHAITER { get; set; }
    }
}
