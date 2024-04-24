using LibrarieModele;
using NivelStocareDate;
using System.Configuration;
using System.Linq;
using System;
using System.IO;
using System.Xml.Linq;

namespace Proiect
{
    
    internal class Program
    { 
        public static int nrProduse = 0,nrClienti = 0;/**id*/
        static void Main()
        {
            //Administrare_Memorie_Produs adminProdusec = new Administrare_Memorie_Produs();
            string numeFisierProduse = ConfigurationManager.AppSettings["NumeFisierProdus"];
            string locatieFisierSolutieP = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisierP = locatieFisierSolutieP + "\\" + numeFisierProduse;
            Administrare_FisierText_Produs adminProduse = new Administrare_FisierText_Produs(caleCompletaFisierP);

            Produs produsNou = new Produs(),_produs;
            Produs[] produse= adminProduse.GetProduse(out nrProduse);/**id*/

            int _nrProduse = 0, _nrClienti = 0;

            //Administrare_Memorie_Client adminClientic = new Administrare_Memorie_Client();
            string numeFisierClienti = ConfigurationManager.AppSettings["NumeFisierClient"];
            string locatieFisierSolutieC = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisierC = locatieFisierSolutieC + "\\" + numeFisierClienti;
            Administrare_FisierText_Client adminClienti = new Administrare_FisierText_Client(caleCompletaFisierC);

            Client clientNou = new Client(),_client;
            Client[] clienti= adminClienti.GetClienti(out nrClienti);/**id*/

            string _nume = string.Empty, _prenume = string.Empty;
      

            string optiune;
            do
            {
                Console.WriteLine("CC. Citire informatii client de la tastatura");
                Console.WriteLine("IC. Afisarea informatiilor despre ultimul client introdus");
                Console.WriteLine("NC. Afisarea numelui complet al ultimului client introdus");
                Console.WriteLine("AC. Afisare clienti din fisier");
                Console.WriteLine("SC. Salvare client in vector de obiecte");
                Console.WriteLine("PC. Cauta client dupa nume si prenume");//primul
                Console.WriteLine("LC. Cauta client dupa nume");//toti
                Console.WriteLine("TC. Cauta client dupa numar de telefon");//primul 
                Console.WriteLine("DC. Cauta client dupa CNP");//primul

                Console.WriteLine("\nCP. Citire informatii produs de la tastatura");
                Console.WriteLine("AP. Afisare produse din fisier");
                Console.WriteLine("SP. Salvare produs in vector de obiecte");
                Console.WriteLine("PP. Cauta produs dupa nume");//primul
                Console.WriteLine("LP. Cauta produs dupa tip");//toate

                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "CC":
                        clientNou = CitireClientTastatura();
                        break;

                    case "CP":
                        produsNou = CitireProdusTastatura();
                        break;

                    case "IC":
                        AfisareClient(clientNou);
                        break;

                    case "NC":
                        Console.WriteLine(clientNou.NumeComplet);
                        break;

                    case "AC":
                        clienti = adminClienti.GetClienti(out nrClienti);
                        AfisareClienti(clienti, nrClienti);
                        break;

                    case "AP":
                        produse = adminProduse.GetProduse(out nrProduse);
                        AfisareProduse(produse, nrProduse);
                        break;

                    case "LC":
                        Console.WriteLine("Introduceti numele cautat");
                        _nume = Console.ReadLine();
                        clienti = adminClienti.GetClient(_nume, out _nrClienti);
                        if (clienti.Length>0)
                            AfisareClienti(clienti, _nrClienti);
                        else
                            Console.WriteLine("Nu s-a gasit!");
                        break;

                    case "PC":
                        Console.WriteLine("Introduceti numele cautat");
                        _nume = Console.ReadLine();

                        Console.WriteLine("Introduceti prenumele cautat");
                        _prenume = Console.ReadLine();
                        _client=adminClienti.GetClient(_nume, _prenume);
                        if(_client!=null)
                            AfisareClient(_client);
                        else
                            Console.WriteLine("Nu s-a gasit!");
                        break;

                    case "LP":
                        Console.WriteLine("Introduceti tipul de produs cautat: ");
                        Console.WriteLine("0 - Nedefinit \n" +
                        "1 - Alimentar \n" +
                        "2 - Electronic \n" +
                        "3 - Vestimentar \n" +
                        "4 - Casnic \n" +
                        "5 - Sport \n" +
                        "6 - Carte \n" +
                        "7 - Jucarie\n" +
                        "8 - Sanatate \n" +
                        "9 - Mobila \n" +
                        "10 - Gradinarit \n" +
                        "11 - Cosmetic");
                        
                        produse = adminProduse.GetProdus((Enumerari.TipProdus)int.Parse(Console.ReadLine()), out _nrProduse);
                        if (produse.Length > 0)
                            AfisareProduse(produse, _nrProduse);
                        else
                            Console.WriteLine("Nu s-a gasit!");
                        break;

                    case "PP":
                        Console.WriteLine("Introduceti numele cautat");
                        _nume = Console.ReadLine();

                        _produs = adminProduse.GetProdus(_nume);
                        if (_produs != null)
                            AfisareProdus(_produs);
                        else
                            Console.WriteLine("Nu s-a gasit!");
                        break;

                    case "TC":
                        Console.WriteLine("Introduceti numarul de telefon cautat");
                        _nume = Console.ReadLine();
                        while (_nume.Length != 10 || !_nume.All(char.IsDigit))
                        {
                            Console.WriteLine("Introduceti numarul de telefon");
                            _nume = Console.ReadLine();
                        }
                        _client = adminClienti.GetClient(_nume, true);
                        if (_client != null)
                            AfisareClient(_client);
                        else
                            Console.WriteLine("Nu s-a gasit!");
                        break;

                    case "DC":
                        Console.WriteLine("Introduceti CNP-ul cautat");
                        _nume = Console.ReadLine();
                        while (_nume.Length != 13 || !"1256".Contains(_nume[0]) || !_nume.All(char.IsDigit))
                        {
                            Console.WriteLine("Introduceti CNP-ul");
                            _nume = Console.ReadLine();
                        }
                        _client = adminClienti.GetClient(_nume, false);
                        if (_client != null)
                            AfisareClient(_client);
                        else
                            Console.WriteLine("Nu s-a gasit!");
                        break;

                    case "SC":
                        clientNou.IdClient = ++ nrClienti;/**id*/

                        //adaugare client in vectorul de obiecte
                        adminClienti.AddClient(clientNou);
                    
                        break;

                    case "SP":
                        produsNou.IdProdus =++ nrProduse;/**id*/

                        //adaugare client in vectorul de obiecte
                        adminProduse.AddProdus(produsNou);
                        
                        break;

                    case "X":
                        return;

                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static Client CitireClientTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string Nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele");
            string Prenume = Console.ReadLine();

            Console.WriteLine("Introduceti CNP-ul");
            string CNP = Console.ReadLine();
            while (CNP.Length != 13 || !"1256".Contains(CNP[0]) || !CNP.All(char.IsDigit))
            {
                Console.WriteLine("Introduceti CNP-ul");
                CNP = Console.ReadLine();
            }

            Console.WriteLine("Introduceti numarul de telefon");
            string NrTelefon = Console.ReadLine();
            while (NrTelefon.Length != 10 || !NrTelefon.All(char.IsDigit))
            {
                Console.WriteLine("Introduceti numarul de telefon");
                NrTelefon = Console.ReadLine();
            }

            Console.WriteLine("Introduceti bugetul");
            float buget = float.Parse(Console.ReadLine());

            Client client = new Client(Nume, Prenume, CNP, NrTelefon , buget);
            
            return client;
        }

        public static void AfisareClient(Client client)
        {
            string infoclient = string.Format("Client cu Id-ul #{0} are CNP-ul: {1}, numele: {2} {3}, bugetul: {4} si numarul de telefon:{5}",
                    client.IdClient,
                    client.CNP ?? " NECUNOSCUT ",
                    client.Nume ?? " NECUNOSCUT ",
                    client.Prenume ?? " NECUNOSCUT ",
                    client.Buget,
                    client.NrTelefon);

            Console.WriteLine(infoclient);
        }
        public static void AfisareProdus(Produs produs)
        {
            string infoprodus = string.Format("Produs cu Id-ul #{0} are numele: {1}, cantitatea {2}, pretul {3}," +
                "tipul {4} si optiunea/ile {5}",
                    produs.IdProdus,
                    produs.Nume ?? " NECUNOSCUT ",
                    produs.Cantitate,
                    produs.Pret,
                    produs.Tip_Produs,
                    produs.Optiuni_Produs);

            Console.WriteLine(infoprodus);
        }

        public static void AfisareClienti(Client[] clienti, int _nrClienti)
        {
            Console.WriteLine("Clientii sunt:");
            for (int contor = 0; contor < _nrClienti; contor++)
                Console.WriteLine(clienti[contor].Info()); 
        }
        public static void AfisareProduse(Produs[] produse, int _nrProduse)
        {
            Console.WriteLine("Produsele sunt:");
            for (int contor = 0; contor < _nrProduse; contor++)
                Console.WriteLine(produse[contor].Info());
        }
        public static Produs CitireProdusTastatura()
        {
            Console.WriteLine("Introduceti numele");
            string Nume = Console.ReadLine();

            Console.WriteLine("Introduceti cantitatea");
            int Cantitate = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti pretul");
            float Buget = float.Parse(Console.ReadLine());

            Produs produs = new Produs(Nume,Cantitate,Buget);

            Console.WriteLine("Alegeti un tip de produs: ");
            Console.WriteLine("0 - Nedefinit \n" +
                        "1 - Alimentar \n" +
                        "2 - Electronic \n" +
                        "3 - Vestimentar \n" +
                        "4 - Casnic \n" +
                        "5 - Sport \n" +
                        "6 - Carte \n" +
                        "7 - Jucarie\n" +
                        "8 - Sanatate \n" +
                        "9 - Mobila \n" +
                        "10 - Gradinarit \n" +
                        "11 - Cosmetic");
            int optiune = Convert.ToInt32(Console.ReadLine());
            produs.Tip_Produs=(Enumerari.TipProdus)optiune;
            
            Console.WriteLine("Alegeti mai multe optiuni pentru produs (prin virgula): ");
            Console.WriteLine("0 - Nedefinit \n" +
                        "1 - Reciclabil \n" +
                        "2 - Premium \n" +
                        "3 - Editie limitata \n" +
                        "4 - Garantie extinsa \n" +
                        "5 - Personalizabil \n" +
                        "6 - Disponibil online \n" +
                        "7 - Disponibil fizic\n" +
                        "8 - TravelSize \n" +
                        "9 - Retur usor \n" +
                        "10 - Vegan \n" +
                        "11 - Brand \n"+
                        "12 - NoName \n" +
                        "13 - Handmade");

            string[] input = Console.ReadLine().Split(',');
            Enumerari.OptiuniProdus Optiuni = Enumerari.OptiuniProdus.Nedefinit;

            foreach (var _optiune in input)
                if (int.TryParse(_optiune.Trim(), out int x))
                    if(x!=0)
                        Optiuni |= (Enumerari.OptiuniProdus)(1<<x-1);

            produs.Optiuni_Produs = (Enumerari.OptiuniProdus)Optiuni;
            return produs;
        }
    }
}
