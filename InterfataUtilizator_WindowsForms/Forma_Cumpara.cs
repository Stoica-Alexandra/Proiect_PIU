using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelStocareDateProdus;
using NivelStocareDateClient;
using EvidentaStudenti_UI_WindowsForms;
using LibrarieModele;
using static LibrarieModele.Enumerari;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Forma_Cumpara : Form
    {
        IStocareData_Client adminClienti;
        IStocareData_Produs adminProduse;
        private static int ID;
        public Forma_Cumpara(int index)
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocareClient();
            adminProduse = StocareFactory.GetAdministratorStocareProdus();

            ID = index;

            AfiseazaListaCompleta();
        }

        private void btnCumpara_Click(object sender, EventArgs e)
        {
            if (lstProdus.SelectedItem == null)
            {
                lblInfo.Text = "Selectați un produs din listă.";
                return; 
            }
            var selectedInfoScurt = lstProdus.SelectedItem.ToString();
            Produs selectedProdus = adminProduse.GetProduse()
                                        .FirstOrDefault(produs => produs.InfoScurt == selectedInfoScurt);

            if (selectedProdus == null)
            {
                lblInfo.Text = "Produsul selectat nu a fost găsit.";
                return; 
            }
            if (selectedProdus.ProduseDisponibile == 0)
            {
                lblInfo.Text = "Nu sunt produse disponibile.";
                return; 
            }

            Client client = adminClienti.GetClientbyIndex(ID);
            if (client.Cumparare(selectedProdus)==true)
            {
                adminProduse.UpdateProdus(selectedProdus);
                adminClienti.UpdateClient(client);
                MessageBox.Show("Cumpărare efectuată cu succes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
                MessageBox.Show("Clientul a ajuns la numărul maxim de produse cumpărate sau buget insuficient!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AfiseazaListaCompleta()
        {
            lstProdus.Items.Clear();

            if (string.IsNullOrWhiteSpace(cbxTip.Text) == false)
            {
                TipProdus tip = (TipProdus)Enum.Parse(typeof(TipProdus), cbxTip.Text.ToString());
                List<Produs> produse = adminProduse.GetProdus(tip);
              
                if (produse.Count > 0)
                    foreach (Produs produs in produse)
                        lstProdus.Items.Add(produs.InfoScurt);
                else
                    MessageBox.Show("Nu s-a găsit!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void cbxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
                AfiseazaListaCompleta(); 
        }
    }
}
