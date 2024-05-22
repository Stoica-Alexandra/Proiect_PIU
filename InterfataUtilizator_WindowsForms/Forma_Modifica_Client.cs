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
using EvidentaStudenti_UI_WindowsForms;
using LibrarieModele;
using NivelStocareDateClient;
using NivelStocareDateProdus;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Forma_Modifica_Client : Form
    {
        IStocareData_Client adminClienti;
        public static int ID;

        public Forma_Modifica_Client(int id)
        {
            InitializeComponent();
            ID = id;
            adminClienti = StocareFactory.GetAdministratorStocareClient();
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (Validare() == true)
            {
                adminClienti = StocareFactory.GetAdministratorStocareClient();

                Client client_nemodificat = adminClienti.GetClientbyIndex(ID);
                Client client = new Client(txtNume.Text, txtPrenume.Text, txtCNP.Text, txtNrTelefon.Text, float.Parse(txtBuget.Text));
                client.IdClient = ID;
                client.NrProduse = client_nemodificat.NrProduse;
                client.ProduseId = client_nemodificat.ProduseId;

                if (adminClienti.UpdateClient(client) == true)
                {
                    MessageBox.Show("Clientul a fost modificat cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    this.Close();
                }
            }
        }
        public void SetareControale(Client client)
        {
            txtNume.Text = client.Nume;
            txtPrenume.Text = client.Prenume;
            txtCNP.Text = client.CNP;
            txtNrTelefon.Text = client.NrTelefon;
            txtBuget.Text = client.Buget.ToString();
        }
        private void ShowError(Label label, string message)
        {
            label.ForeColor = System.Drawing.Color.Red; // Schimbare culoare text în roșu
            MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool Validare()
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) == true)
            {
                ShowError(lblNume, "Introduceți numele");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                ShowError(lblPrenume, "Introduceți prenumele");
                return false;
            }

            if (Client.ValidareCNP(txtCNP.Text) == false || string.IsNullOrWhiteSpace(txtCNP.Text))
            {
                ShowError(lblCNP, "Introduceți CNP-ul");
                return false;
            }

            if (Client.ValidareNrTelefon(txtNrTelefon.Text) == false || string.IsNullOrWhiteSpace(txtNrTelefon.Text))
            {
                ShowError(lblNrTelefon, "Introduceți numărul de telefon");
                return false;
            }

            if (!float.TryParse(txtBuget.Text, out float buget))
            {
                ShowError(lblBuget, "Introduceți bugetul");
                return false;
            }
            return true;
        }
    }
}
