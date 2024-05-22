using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelStocareDateClient;
using NivelStocareDateProdus;

namespace EvidentaStudenti_UI_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER_CLIENT = "NumeFisierClient";
        private const string NUME_FISIER_PRODUS = "NumeFisierProdus";

        public static IStocareData_Client GetAdministratorStocareClient()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];

            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER_CLIENT];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new Administrare_FisierText_Client(caleCompletaFisier + "." + formatSalvare);
                }
            }

            return null;
        }
        public static IStocareData_Produs GetAdministratorStocareProdus()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];

            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER_PRODUS];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "txt":
                        return new Administrare_FisierText_Produs(caleCompletaFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}

