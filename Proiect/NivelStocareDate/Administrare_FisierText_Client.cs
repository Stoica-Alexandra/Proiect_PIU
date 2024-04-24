using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class Administrare_FisierText_Client
    {
        private const int NR_MAX_CLIENTI = 50;
        private string numeFisier;
        /**din administrare  memorie*/
        private Client[] clienti;
        private int nrClienti;
        public Administrare_FisierText_Client(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddClient(Client client)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public Client[] GetClienti(out int nrClienti)
        {
            /*Client[]*/ clienti = new Client[NR_MAX_CLIENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
               nrClienti = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }

            return clienti;
        }
        /**din administrare  memorie*/
        public Client GetClient(string Nume, string Prenume)
        {
            foreach (Client client in clienti)
                if (client != null && client.Nume == Nume && client.Prenume == Prenume)
                    return client;
            return null;
        }
        public Client GetClient(string str, bool ok)//
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
