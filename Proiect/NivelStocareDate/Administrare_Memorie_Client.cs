using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class Administrare_Memorie_Client
    {
        private const int NR_MAX_CLIENTI = 50;//

        private Client[] clienti;
        private int nrClienti;

        public Administrare_Memorie_Client()//
        {
            clienti = new Client[NR_MAX_CLIENTI];
            nrClienti = 0;
        }

        public void AddClient(Client client)//
        {
            clienti[nrClienti] = client;
            nrClienti++;
        }

        public Client[] GetClienti(out int nrClienti)//
        {
            nrClienti = this.nrClienti;
            return clienti;
        }

        public Client GetClient(string Nume, string Prenume)
        {
            foreach (Client client in clienti)
                if (client != null && client.Nume == Nume && client.Prenume == Prenume)
                    return client;
            return null;
        }
        public Client GetClient(string str,bool ok)//
        {
            if (ok == false)
            {
                foreach (Client client in clienti)
                    if (client != null && client.CNP == str)
                        return client;
            }
            else
            {
                foreach (Client client in clienti)
                    if (client != null && client.NrTelefon == str)
                        return client;
            }
            return null;
        }
        public Client[] GetClient(string Nume, out int nrClienti)
        {
            int nr = 0;
            foreach (Client client in clienti)
                if (client != null && client.Nume == Nume)
                    nr++;

            Client[] _clienti = new Client[nr];
            nrClienti = 0;
            foreach (Client client in clienti)
                if (client != null && client.Nume == Nume)
                    _clienti[nrClienti++] = client;
            if (nrClienti != 0)
                return _clienti;
            else
                return new Client[0];
        }
    }
}
