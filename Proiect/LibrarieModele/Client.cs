using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Client
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int _CNP_ = 3;
        private const int  NR_TELEFON= 4;
        private const int BUGET = 5;

        public int Nr_Clienti = 0;
        //proprietati auto-implemented
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public float Buget { get; set; }
        public int IdClient { get; set; }
        private string _NrTelefon, _CNP;
        public string NrTelefon
        {
            get
            {
                return _NrTelefon;
            }
            set
            {
                if (
                    _NrTelefon != value && value.Length == 10 && value.All(char.IsDigit))
                    _NrTelefon = value;
            }
        }
        public string CNP
        {
            get
            {
                return _CNP;
            }
            set
            {
            if (_CNP != value && value.Length == 13 && "1256".Contains(value[0]) && value.All(char.IsDigit))
                    _CNP = value;
            }
        }
        public string NumeComplet
        {
            get
            {
                return $"{Nume} {Prenume}";
            }
        }
        //constructor implicit
        public Client()
        {
            Nume = Prenume = CNP = NrTelefon = string.Empty;
            IdClient = 0;
            Buget = 0.0F;
        }
        //constructor cu parametrii
        public Client(string nume, string prenume, string _CNP = " NECUNOSCUT ", string nrtelefon = " NECUNOSCUT ", float buget = 0.0F)
        {
            Nume = nume;
            Prenume = prenume;
            if (_CNP.Length == 13 && "1256".Contains(_CNP[0]) && _CNP.All(char.IsDigit))
                CNP = _CNP;
            if (nrtelefon.Length == 10 && nrtelefon.All(char.IsDigit))
                NrTelefon = nrtelefon;
            Buget = buget;
        }
        public string Info()
        {
            string info = $"IdClient : {IdClient}, Nume : {Nume ?? " NECUNOSCUT "}, Prenume : {Prenume ?? " NECUNOSCUT "}, " +
                $"Buget : {Buget}, CNP : {CNP ?? " NECUNOSCUT "}, NrTelefon : {NrTelefon ?? " NECUNOSCUT "}";
            return info;
        }
        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.IdClient = Convert.ToInt32(dateFisier[ID]);
            this.Nume = dateFisier[NUME];
            this.Prenume = dateFisier[PRENUME];
            this.CNP = dateFisier[_CNP_];
            this.NrTelefon = dateFisier[NR_TELEFON];
            this.Buget = Convert.ToSingle(dateFisier[BUGET]);//float
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectClientPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdClient.ToString(),
                (Nume ?? " NECUNOSCUT "),
                (Prenume ?? " NECUNOSCUT "),
                (CNP ?? " NECUNOSCUT "),
                (NrTelefon ?? " NECUNOSCUT "),
                Buget.ToString()
                );

            return obiectClientPentruFisier;
        }
    }
}
