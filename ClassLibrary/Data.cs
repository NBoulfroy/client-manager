using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    [Serializable]
    public class Data
    {
        private List<Client> clients;

        public Data()
        {
            clients = new List<Client>();
        }

        #region Accessors

        public List<Client> GetClients() { return clients; }

        #endregion

        #region Properties

        public List<Client> Clients { get { return clients; } }

        #endregion

        #region Methods

        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void SubstractClient(int id)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].GetId() == id)
                {
                    clients.Remove(clients[i]);
                }
            }
        }

        public void UpdateClient(int id, string lastName, string firstName)
        {
            foreach (Client client in clients)
            {
                if (client.GetId() == id)
                {
                    client.SetId(id);
                    client.SetLastName(lastName.ToUpper());
                    client.SetFirstName(firstName);
                }
            }
        }

        #endregion
    }
}
