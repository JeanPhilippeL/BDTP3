using app.domain.membre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.IntegrationTests.MocksEntities
{
    public class MockMembre
    {
        List<Membre> MOCK_MEMBRES = new List<Membre>() {
            new Membre()
            {
                ROLE = "Magicien",
                ID_ARTISTE = 1,
                NOM_DU_GROUPE = "DabTea"
            },
            new Membre()
            {
                ROLE = "Pianiste",
                ID_ARTISTE = 2,
                NOM_DU_GROUPE = "ClassicTea"
            },
            new Membre()
            {
                ROLE = "Programmeur",
                ID_ARTISTE = 3,
                NOM_DU_GROUPE = "WifiTea"
            },
        };
    }
}
