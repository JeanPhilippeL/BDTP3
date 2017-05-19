using app.domain.artiste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.IntegrationTests.MocksEntities
{
    public class MockArtiste
    {
         List<Artiste> MOCK_ARTISTES = new List<Artiste>() {
            new Artiste()
            {
                ID_ARTISTE = 1,
                NAS = 987654321,
                NOM_ARTISTE = "Mathieu",
                NOM_DE_SCENE = "Prince",
                PRENOM_ARTISTE = "Agulim",
                TELEPHONE = "5817777778"

            },
            new Artiste()
            {
                ID_ARTISTE = 2,
                NAS = 123456789,
                NOM_ARTISTE = "Alexis Gagnon",
                NOM_DE_SCENE = "SignMeDown",
                PRENOM_ARTISTE = "5817777778",
                TELEPHONE = "5817777779"
            },
            new Artiste()
            {
                ID_ARTISTE = 3,
                NAS = 741852963,
                NOM_ARTISTE = "Deshaies",
                NOM_DE_SCENE = "BlackMagic",
                PRENOM_ARTISTE = "Jean",
                TELEPHONE = "5147896545"
            },
        };
    }
}
