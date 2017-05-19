using app.domain.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.IntegrationTests.MocksEntities
{
    public class MockClient
    {
        List<Client> MOCK_CLIENTS = new List<Client>() {
            new Client()
            {
                ID_CLIENT = 1,
                NOM_CLIENT = "Travis Clint",
                REFERENCE = "",
                TELEPHONE_CLIENT = "5817777778"
            },
            new Client()
            {
                ID_CLIENT = 2,
                NOM_CLIENT = "Daniel Lorent",
                REFERENCE = "",
                TELEPHONE_CLIENT = "5817777777"
            },
            new Client()
            {
                ID_CLIENT = 3,
                NOM_CLIENT = "Anie Hilton",
                REFERENCE = "",
                TELEPHONE_CLIENT = "5817777776"
            },
        };
    }
}
