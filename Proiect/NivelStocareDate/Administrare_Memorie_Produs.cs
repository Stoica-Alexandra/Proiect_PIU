using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class Administrare_Memorie_Produs
    {
        private const int NR_MAX_PRODUSE = 50;//

        private Produs[] produse;
        private int nrProduse;

        public Administrare_Memorie_Produs()//
        {
            produse = new Produs[NR_MAX_PRODUSE];
            nrProduse = 0;
        }

        public void AddProdus(Produs produs)//
        {
            produse[nrProduse] = produs;
            nrProduse++;
        }

        public Produs[] GetProduse(out int nrProduse)//
        {
            nrProduse = this.nrProduse;
            return produse;
        }
        public Produs GetProdus(string Nume)
        {
            foreach (Produs produs in produse)
                if (produs!= null && produs.Nume == Nume)
                    return produs;
            return null;
        }
        public Produs[] GetProdus(Enumerari.TipProdus categorie, out int nrProduse)
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
