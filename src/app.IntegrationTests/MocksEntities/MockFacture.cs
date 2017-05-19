using app.domain.facture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.IntegrationTests.MocksEntities
{
    public class MockFacture
    {
        List<Facture> MOCK_FACTURES = new List<Facture>() {
            new Facture()
            {
                ID_CLIENT = 1,
                ID_CONTRAT = 1,
                DATE_DE_PRODUCTION = new DateTime(2017, 7, 1, 7, 0, 0)
            },
            new Facture()
            {
                ID_CLIENT = 2,
                ID_CONTRAT = 2,
                DATE_DE_PRODUCTION = new DateTime(2017, 5, 1, 7, 0, 0)
            },
            new Facture()
            {
                ID_CLIENT = 3,
                ID_CONTRAT = 3,
                DATE_DE_PRODUCTION = new DateTime(2017, 2, 1, 7, 0, 0)
            },
        };
    }
}
