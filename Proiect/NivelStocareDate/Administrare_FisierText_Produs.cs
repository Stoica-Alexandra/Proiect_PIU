using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class Administrare_FisierText_Produs
    {
        private const int NR_MAX_PRODUSE = 50;
        private string numeFisier;

        /**din administrare  memorie*/
        private Produs[] produse;
        private int nrProduse;

        public Administrare_FisierText_Produs(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddProdus(Produs produs)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(produs.ConversieLaSir_PentruFisier());
            }
        }

        public Produs[] GetProduse(out int nrProduse)
        {
            /*Produs[]*/ produse = new Produs[NR_MAX_PRODUSE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrProduse = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    produse[nrProduse++] = new Produs(linieFisier);
                }
            }

            return produse;
        }

        /**din administrare  memorie*/

        public Produs GetProdus(string Nume)
        {
            foreach (Produs produs in produse)
                if (produs != null && produs.Nume == Nume)
                    return produs;
            return null;
        }
        public Produs[] GetProdus(Enumerari.TipProdus categorie , out int nrProduse)
        {
            int nr = 0;
            foreach (Produs produs in produse)
                if (produs != null && produs.Tip_Produs == categorie)
                    nr++;

            Produs[] _produse = new Produs[nr];
            nrProduse = 0;
            foreach (Produs produs in produse)
                if (produs != null && produs.Tip_Produs == categorie)
                    _produse[nrProduse++] = produs;
            if (nrProduse != 0)
                return _produse;
            else
                return new Produs[0];
        }
    }
}
