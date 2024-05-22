using EvidentaStudenti_UI_WindowsForms;
using InterfataUtilizator_WindowsForms;
using LibrarieModele;
using NivelStocareDateClient;
using NivelStocareDateProdus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Forma_Afisare_Client : Form
    {
        IStocareData_Client adminClienti;
        public Forma_Afisare_Client()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocareClient();

            List<Client> clienti = adminClienti.GetClienti();
            Client.NextId = clienti.Count;

            Afisare_Clienti(clienti);
        }

        private void btnAdauga_Client_Click(object sender, EventArgs e)
        {
            (new Forma_Adauga_Client()).Show();
        }

        private void btnModifica_Client_Click(object sender, EventArgs e)
        {
            if (dgvAfisareClienti.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAfisareClienti.SelectedRows[0].Index;
                IStocareData_Client adminClienti = StocareFactory.GetAdministratorStocareClient();
                Client selectedClient = adminClienti.GetClientbyIndex(selectedRowIndex+1);

                if (selectedClient != null)
                {
                    Forma_Modifica_Client forma = new Forma_Modifica_Client(selectedRowIndex + 1);
                    forma.SetareControale(selectedClient);
                    forma.Show();
                }
            }
            else
                MessageBox.Show("Nu s-a selectat corect rândul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Afisare_Clienti(List<Client> clienti)
        {
            dgvAfisareClienti.DataSource = null;
            dgvAfisareClienti.DataSource = clienti.Select(s => new { s.IdClient, s.Nume, s.Prenume, s.CNP, s.NrTelefon, s.Buget, s.NrProduse, s.ProduseId}).ToList();
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            (new Forma_Cauta_Client()).Show();
            this.Hide();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvAfisareClienti.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAfisareClienti.SelectedRows[0].Index;
                IStocareData_Client adminClienti = StocareFactory.GetAdministratorStocareClient();
                Client selectedClient = adminClienti.GetClientbyIndex(selectedRowIndex + 1);

                if (selectedClient != null)
                    (new Forma_Sigur("Client", selectedRowIndex + 1)).Show(); 
            }
            else
                MessageBox.Show("Nu s-a selectat corect rândul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            List<Client> clienti = adminClienti.GetClienti();
            Client.NextId = clienti.Count;

            Afisare_Clienti(clienti);
        }

        private void btnCumpara_Click(object sender, EventArgs e)//
        {
            (new Forma_Main()).Show();
            this.Hide();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            (new Forma_Main()).Show();
            this.Hide();
        }
    }
}
