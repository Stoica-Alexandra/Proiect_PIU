using EvidentaStudenti_UI_WindowsForms;
using LibrarieModele;
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
    public partial class Forma_Cauta_Client : Form
    {
        IStocareData_Client adminClienti;
        public Forma_Cauta_Client()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocareClient();

        }

        private void btnNume_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrenume.Text) == false && string.IsNullOrWhiteSpace(txtNume.Text) == false)
            {
                List<Client> clienti= new List<Client>();
                clienti.Add(adminClienti.GetClient(txtNume.Text, txtPrenume.Text));
                if (adminClienti.GetClient(txtNume.Text, txtPrenume.Text)!=null)
                    Afisare(clienti);
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Clear();
                txtPrenume.Clear();
            }
            else
                MessageBox.Show("Introduceți numele sau/și prenumele!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Afisare(List<Client> clienti)
        {
            dgvCauta.DataSource = null;
            dgvCauta.DataSource = clienti.Select(s => new { s.IdClient, s.Nume, s.Prenume, s.CNP, s.NrTelefon, s.Buget, s.NrProduse, s.ProduseId }).ToList();
        }
        private void btnCNP_Click(object sender, EventArgs e)
        {
            if (Client.ValidareCNP(txtCNP.Text) == true && string.IsNullOrWhiteSpace(txtCNP.Text)==false)
            {
                List<Client> clienti = new List<Client>();
                clienti.Add(adminClienti.GetClient(txtCNP.Text,false));
                if(adminClienti.GetClient(txtCNP.Text, false) != null)
                    Afisare(clienti); 
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCNP.Clear();
            }
            else
                MessageBox.Show("Introduceți CNP-ul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNrTelefon_Click(object sender, EventArgs e)
        {
            if (Client.ValidareNrTelefon(txtNrTelefon.Text) == true && string.IsNullOrWhiteSpace(txtNrTelefon.Text)==false)
            {
                List<Client> clienti = new List<Client>();
                clienti.Add(adminClienti.GetClient(txtNrTelefon.Text, true));
                if (adminClienti.GetClient(txtNrTelefon.Text, true) != null)
                    Afisare(clienti);
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNrTelefon.Clear();
            }
            else
                MessageBox.Show("Introduceți numărul de telefon!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCautareNume_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) == false)
            {
                List<Client> clienti = new List<Client>();
                clienti=adminClienti.GetClient(txtNume.Text);
                if (adminClienti.GetClient(txtNume.Text).Count>0)
                    Afisare(clienti);
                else
                    MessageBox.Show("Nu s-a găsit!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNume.Clear();
                txtPrenume.Clear();
            }
            else
                MessageBox.Show("Introduceți numele!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
