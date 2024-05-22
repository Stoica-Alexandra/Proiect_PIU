using EvidentaStudenti_UI_WindowsForms;
using LibrarieModele;
using NivelStocareDateProdus;
using NivelStocareDateClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    
    public partial class Forma_Sigur : Form
    {
        private static int ID;
        private static string STR;
        public Forma_Sigur(string str,int id)
        {
            InitializeComponent();
            ID = id;
            STR = str;
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            if( STR =="Client")
                {
                    IStocareData_Client adminClienti = StocareFactory.GetAdministratorStocareClient();
                    Client selectedClient = adminClienti.GetClientbyIndex(ID);
                    adminClienti.StergeClient(selectedClient);
                    MessageBox.Show("Clientul a fost șters cu succes din fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                if(STR== "Produs")
                {
                    IStocareData_Produs adminProduse = StocareFactory.GetAdministratorStocareProdus();
                    Produs selectedProdus = adminProduse.GetProdustbyIndex(ID);
                    adminProduse.StergeProdus(selectedProdus);
                    MessageBox.Show("Produsul a fost șters cu succes din fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void btnNu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
