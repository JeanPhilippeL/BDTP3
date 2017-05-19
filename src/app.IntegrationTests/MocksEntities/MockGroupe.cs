using app.domain.groupe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.IntegrationTests.MocksEntities
{
    public class MockGroupe
    {
        List<Groupe> MOCK_GROUPES = new List<Groupe>() {
            new Groupe()
            {
                CACHET_SOUHAITER = 1000,
                NOM_DU_GROUPE = "AllMetal"
            },
            new Groupe()
            {
                CACHET_SOUHAITER = 215,
                NOM_DU_GROUPE = "SlowMindWind"
            },
            new Groupe()
            {
                CACHET_SOUHAITER = 222,
                NOM_DU_GROUPE = "LastFlyCrew"
            }
        };
    }
}

