using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static LibrarieModele.Enumerari;

namespace LibrarieModele
{
    public class Produs
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int CANTITATE = 2;
        private const int PRET = 3;
        private const int TIP_PRODUS = 4;
        private const int OPTIUNI_PRODUS = 5;

        //proprietati auto-implemented
        public string Nume { get; set; }
        public int IdProdus { get; set; }
        public float Pret { get; set; }
        public int Cantitate { get; set; }  
        public Enumerari.OptiuniProdus Optiuni_Produs{ get; set; }
        public Enumerari.TipProdus Tip_Produs { get; set; }

        //constructor implicit
        public Produs()
        {
            Nume = string.Empty;
            IdProdus = 0;
            Pret = 0.0F;
            Cantitate = 0;
        }
        //constructor cu parametrii
        public Produs(string nume, int cantitate, float pret)
        {
            Nume=nume;
            Pret=pret;
            Cantitate=cantitate;
        }
        public string Info()
        {
            string info = $"IdProdus : {IdProdus}, Nume : {Nume ?? " NECUNOSCUT "}, Cantitate : {Cantitate}, Pret : {Pret}, " +
                $"Tip produs : {Tip_Produs}, Optiuni : {Optiuni_Produs}";
            return info;
        }
        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.IdProdus = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Cantitate = int.Parse(dateFisier[CANTITATE]);
            this.Pret = Convert.ToSingle(dateFisier[PRET]);//float

            TipProdus tipProdus;
            if (Enum.TryParse(dateFisier[TIP_PRODUS], out tipProdus))
                this.Tip_Produs = tipProdus;
            else
                this.Tip_Produs = TipProdus.Nedefinit;  

            OptiuniProdus optiuni;
            if (Enum.TryParse(dateFisier[OPTIUNI_PRODUS], out optiuni))
                this.Optiuni_Produs = optiuni;
            else
                this.Optiuni_Produs = OptiuniProdus.Nedefinit;  
        }
    
        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdProdus.ToString(),
                (Nume ?? " NECUNOSCUT "),
                Cantitate.ToString(),
                Pret.ToString(),
                Tip_Produs,
                Optiuni_Produs
                );

            return obiectProdusPentruFisier;
        }
    }
}
