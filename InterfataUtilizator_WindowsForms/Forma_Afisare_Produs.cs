using EvidentaStudenti_UI_WindowsForms;
using LibrarieModele;
using NivelStocareDateClient;
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
using NivelStocareDateProdus;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Forma_Afisare_Produs : Form
    {
        IStocareData_Produs adminProduse;
        public Forma_Afisare_Produs()
        {
            InitializeComponent();
            adminProduse = StocareFactory.GetAdministratorStocareProdus();

            List<Produs> produse = adminProduse.GetProduse();
            Produs.NextId = produse.Count;

            Afisare_Produse(produse);
        }

        public void Afisare_Produse(List<Produs> produse)
        {
            dgvAfisareProduse.DataSource = null;
            dgvAfisareProduse.DataSource = produse.Select(s => new { s.IdProdus, s.Nume, s.Pret,s.Cantitate, s.Tip_Produs, s.Optiuni_ProdusAsString, s.ProduseDisponibile }).ToList();
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            (new Forma_Cauta_Client()).Show();//
            this.Hide();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvAfisareProduse.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAfisareProduse.SelectedRows[0].Index;
                IStocareData_Produs adminProduse = StocareFactory.GetAdministratorStocareProdus();
                Produs selectedProdus = adminProduse.GetProdustbyIndex(selectedRowIndex + 1);

                if (selectedProdus != null)
                    (new Forma_Sigur("Produs", selectedRowIndex + 1)).Show();
            }
            else
                MessageBox.Show("Nu s-a selectat corect rândul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            List<Produs> produse = adminProduse.GetProduse();
            Produs.NextId = produse.Count;

            Afisare_Produse(produse);
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

        private void btnAdauga_Produs_Click(object sender, EventArgs e)
        {
            (new Forma_Adauga_Produs()).Show();
        }

        private void btnModifica_Produs_Click(object sender, EventArgs e)
        {
            if (dgvAfisareProduse.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvAfisareProduse.SelectedRows[0].Index;
                IStocareData_Produs adminProduse = StocareFactory.GetAdministratorStocareProdus();
                Produs selectedProdus = adminProduse.GetProdustbyIndex(selectedRowIndex + 1);

                if (selectedProdus != null)
                {
                    Forma_Modifica_Produs forma = new Forma_Modifica_Produs(selectedRowIndex + 1);
                    forma.SetareControale(selectedProdus);
                    forma.Show();
                }
            }
            else
                MessageBox.Show("Nu s-a selectat corect rândul", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
