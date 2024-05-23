using EvidentaStudenti_UI_WindowsForms;
using LibrarieModele;
using NivelStocareDateProdus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarieModele.Enumerari;


namespace InterfataUtilizator_WindowsForms
{
    public partial class Forma_Cauta_Produs : Form
    {
        IStocareData_Produs adminProduse;
        public Forma_Cauta_Produs()
        {
            InitializeComponent();
            adminProduse = StocareFactory.GetAdministratorStocareProdus();
            
        }
        public void Afisare(List<Produs> produse)
        {
            dgvCauta.DataSource = null;
            dgvCauta.DataSource = produse.Select(s => new { s.IdProdus, s.Nume, s.Pret, s.Cantitate, s.Tip_Produs, s.Optiuni_ProdusAsString, s.ProduseDisponibile }).ToList();
        }
        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCautareNume_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) == false)
            {
                List<Produs> produse = new List<Produs>();
                produse = adminProduse.GetProdus(txtNume.Text);
                if (produse.Count > 0)
                    Afisare(produse);
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Clear();
            }
            else
                MessageBox.Show("Introduceți numele!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxTip.Text) == false)
            {
                List<Produs> produse = new List<Produs>();
                TipProdus tip = (TipProdus)Enum.Parse(typeof(TipProdus), cbxTip.Text);
                produse = adminProduse.GetProdus(tip);
                if (produse.Count > 0)
                    Afisare(produse);
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxTip.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Introduceți tipul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPretInterval_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtPret1.Text, out float pret1) && float.TryParse(txtPret2.Text, out float pret2))
            {
                List<Produs> produse = new List<Produs>();
                produse = adminProduse.GetProdus(pret1,pret2);
                if (produse.Count > 0)
                    Afisare(produse);
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Clear();
            }
            else
                MessageBox.Show("Introduceți preț 1 sau/și preț 2!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
