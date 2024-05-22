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
    public partial class Forma_Adauga_Client : Form
    {
        IStocareData_Client adminClienti;
        public Forma_Adauga_Client()
        {
            InitializeComponent();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (Validare() == true)
            {
                adminClienti = StocareFactory.GetAdministratorStocareClient();

                List<Client> clienti = adminClienti.GetClienti();
                Client.NextId = clienti.Count;
                adminClienti.AddClient(new Client(txtNume.Text, txtPrenume.Text, txtCNP.Text, txtNrTelefon.Text, float.Parse(txtBuget.Text)));
                
                MessageBox.Show("Clientul a fost adăugat cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetareCuloareErori();
                ResetareControale();

                this.Close();
            }
            /*else
                ResetareCuloareErori();*/
        }

        public void ResetareControale()
        {
            txtNume.Clear();
            txtPrenume.Clear();
            txtCNP.Clear();
            txtNrTelefon.Clear();
            txtBuget.Clear();
        }
        public void ResetareCuloareErori()
        {
            lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            lblPrenume.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCNP.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNrTelefon.ForeColor = System.Drawing.SystemColors.ControlText;
            lblBuget.ForeColor = System.Drawing.SystemColors.ControlText;
        }
        private void ShowError(Label label, string message)
        {
            label.ForeColor = System.Drawing.Color.Red; // Schimbare culoare text în roșu
            MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool Validare()
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text)==true)
            {
                ShowError(lblNume, "Introduceți numele");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrenume.Text))
            {
                ShowError(lblPrenume, "Introduceți prenumele");
                return false;
            }

            if (Client.ValidareCNP(txtCNP.Text)==false || string.IsNullOrWhiteSpace(txtCNP.Text))
            {
                ShowError(lblCNP, "Introduceți CNP-ul");
                return false;
            }

            if ( Client.ValidareNrTelefon(txtNrTelefon.Text)==false || string.IsNullOrWhiteSpace(txtNrTelefon.Text))
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
