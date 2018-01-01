using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    [Serializable]
    public class Data
    {
        private SortedDictionary<int, Client> clients;

        public Data()
        {
            clients = new SortedDictionary<int, Client>();
        }

        #region Accessors

        public SortedDictionary<int, Client> GetClients() { return clients; }

        #endregion

        #region Properties

        public SortedDictionary<int, Client> Clients { get { return clients; } }

        #endregion

        #region Methods

        public void AddClient(Client client)
        {
            clients.Add(client.GetId(), client);
        }

        public void SubstractClient(int id)
        {
            clients.Remove(id);
        }

        public void UpdateClient(int id, string lastName, string firstName)
        {
            foreach (KeyValuePair<int, Client> client in clients)
            {
                if (client.Value.GetId() == id)
                {
                    client.Value.SetId(id);
                    client.Value.SetLastName(lastName);
                    client.Value.SetFirstName(firstName);
                }
            }
        }

        #endregion
    }
}
