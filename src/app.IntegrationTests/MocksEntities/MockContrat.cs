using app.domain.contrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.IntegrationTests.MocksEntities
{
    public class MockContrat
    {
        List<Contrat> MOCK_CONTRATS = new List<Contrat>() {
            new Contrat()
            {
                ID_CONTRAT = 1,
                ID_CLIENT = 1,
                NOM_DU_GROUPE = "TheDevilsBobettes",
                DATE_PRESTATION = new DateTime(2017, 3, 1, 7, 0, 0),
                HEURE_DEBUT = "20h",
                HEURE_FIN = "23h",
                CACHET_OFFERT = 10
            },
            new Contrat()
            {
                ID_CONTRAT = 2,
                ID_CLIENT = 2,
                NOM_DU_GROUPE = "TheDevilsBoxers",
                DATE_PRESTATION = new DateTime(2017, 5, 1, 7, 0, 0),
                HEURE_DEBUT = "10h",
                HEURE_FIN = "17h",
                CACHET_OFFERT = 10
            },
            new Contrat()
            {
                ID_CONTRAT = 2,
                ID_CLIENT = 2,
                NOM_DU_GROUPE = "HAVE_NICE_VACANCE",
                DATE_PRESTATION = new DateTime(2017, 7, 1, 7, 0, 0),
                HEURE_DEBUT = "10h",
                HEURE_FIN = "13h",
                CACHET_OFFERT = 10
            },
        };
    }
}
