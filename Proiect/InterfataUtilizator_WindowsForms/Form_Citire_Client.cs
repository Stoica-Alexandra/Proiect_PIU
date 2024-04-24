using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using LibrarieModele;
using NivelStocareDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form_Citire_Client : Form
    {
        Administrare_FisierText_Client adminClienti;
        public static int nrClienti = 0;

        private Label lblNume;
        private Label lblPrenume;
        private Label lblCNP;
        private Label lblNumar_Telefon;
        private Label lblBuget;

        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtCNP;
        private TextBox txtNumar_Telefon;
        private TextBox txtBuget;


        private Button btnAdd;
        private Button btnRefresh;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;

        public Form_Citire_Client()
        {
            InitializeComponent();

            //setare proprietati
            //this.AutoSize = true;
            this.Size = new Size(700, 400);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.BackColor = Color.Lavender;
            this.Text = "Informatii clienti";

            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(lblNume);
            

            //adaugare control de tip Label pentru 'Prenume';
            lblPrenume = new Label();
            lblPrenume.Width = LATIME_CONTROL;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = DIMENSIUNE_PAS_X;
            lblPrenume.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblPrenume);

            //adaugare control de tip Label pentru 'CNP';
            lblCNP = new Label();
            lblCNP.Width = LATIME_CONTROL;
            lblCNP.Text = "CNP";
            lblCNP.Left = DIMENSIUNE_PAS_X ;
            lblCNP.Top = DIMENSIUNE_PAS_Y * 2;
            this.Controls.Add(lblCNP);

            //adaugare control de tip Label pentru 'Numar_Telefon';
            lblNumar_Telefon = new Label();
            lblNumar_Telefon.Width = LATIME_CONTROL;
            lblNumar_Telefon.Text = "Număr de telefon";
            lblNumar_Telefon.Left = DIMENSIUNE_PAS_X;
            lblNumar_Telefon.Top = DIMENSIUNE_PAS_Y * 3;
            this.Controls.Add(lblNumar_Telefon);

            //adaugare control de tip Label pentru 'Buget';
            lblBuget = new Label();
            lblBuget.Width = LATIME_CONTROL;
            lblBuget.Text = "Buget";
            lblBuget.Left = DIMENSIUNE_PAS_X;
            lblBuget.Top = DIMENSIUNE_PAS_Y * 4;
            this.Controls.Add(lblBuget);

            //adaugare control de tip Text pentru 'Nume';
            txtNume = new TextBox();
            txtNume.Width = 2*LATIME_CONTROL;
            txtNume.Left =2* DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume);

             //adaugare control de tip Text pentru 'Prenume';
             txtPrenume = new TextBox();
             txtPrenume.Width = 2 * LATIME_CONTROL;
             txtPrenume.Left = 2 * DIMENSIUNE_PAS_X;
             txtPrenume.Top =DIMENSIUNE_PAS_Y;
             this.Controls.Add(txtPrenume);

            //adaugare control de tip Text pentru 'CNP';
            txtCNP = new TextBox();
            txtCNP.Width = 2 * LATIME_CONTROL;
            txtCNP.Left = 2 * DIMENSIUNE_PAS_X;
            txtCNP.Top = 2 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtCNP);

            //adaugare control de tip Text pentru 'Numar_Telefon';
            txtNumar_Telefon = new TextBox();
            txtNumar_Telefon.Width = 2 * LATIME_CONTROL;
            txtNumar_Telefon.Left = 2 * DIMENSIUNE_PAS_X;
            txtNumar_Telefon.Top = 3 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtNumar_Telefon);

            //adaugare control de tip Text pentru 'Buget';
            txtBuget = new TextBox();
            txtBuget.Width = 2 * LATIME_CONTROL;
            txtBuget.Left = 2 * DIMENSIUNE_PAS_X;
            txtBuget.Top = 4 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtBuget);

            //adaugare control de tip Button pentru Adauga
            btnAdd = new Button();
            btnAdd.Width = LATIME_CONTROL;
            btnAdd.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 5 * DIMENSIUNE_PAS_Y);
            btnAdd.BackColor= Color.White;
            btnAdd.Text = "Adauga";
            btnAdd.Click += OnButtonClicked_Add;
            this.Controls.Add(btnAdd);

            //adaugare control de tip Button pentru Refresh
            btnRefresh = new Button();
            btnRefresh.Width = LATIME_CONTROL;
            btnRefresh.Location = new System.Drawing.Point(2*DIMENSIUNE_PAS_X, 5 * DIMENSIUNE_PAS_Y);
            btnRefresh.BackColor = Color.White;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += OnButtonClicked_Refresh; 
            this.Controls.Add(btnRefresh);

            // adaugare handlere pentru evenimentele FormClosed ale formei
            this.FormClosed += OnFormClosed;
        }

        private void OnButtonClicked_Add(object sender, EventArgs e)
        {
            // obiectul *sender* este butonul btnCalculeaza
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button
            // catre subscriber-ul curent care este forma FormularGeometrie 

            string Nume=txtNume.Text;
            string Prenume = txtPrenume.Text;
            string CNP = txtCNP.Text;
            string Nr_Telefon = txtNumar_Telefon.Text;
            string Buget = txtBuget.Text.ToString();

            if (string.IsNullOrWhiteSpace(Nume.ToString()))
            {
                ShowError(lblNume, "Introduceti numele");
                return;
            }

            if (string.IsNullOrWhiteSpace(Prenume.ToString()))
            {
                ShowError(lblPrenume, "Introduceti prenumele");
                return;
            }

            if (string.IsNullOrWhiteSpace(CNP.ToString())|| CNP.Length != 13 || !"1256".Contains(CNP[0]) || !CNP.All(char.IsDigit))
            {
                ShowError(lblCNP, "Introduceti CNP-ul");
                return;
            }

            if (string.IsNullOrWhiteSpace(Nr_Telefon.ToString())|| Nr_Telefon.Length != 10 || !Nr_Telefon.All(char.IsDigit))
            {
                ShowError(lblNumar_Telefon, "Introduceti numarul de telefon");
                return;
            }

            if (!float.TryParse(Buget, out float buget))
            {
                ShowError(lblBuget, "Introduceti bugetul");
                return;
            }

            string numeFisier = ConfigurationManager.AppSettings["NumeFisierClient"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminClienti = new Administrare_FisierText_Client(caleCompletaFisier);

            Client[] clienti = adminClienti.GetClienti(out nrClienti);
            Client clientNou = new Client(Nume, Prenume, CNP, Nr_Telefon, float.Parse(Buget));
            clientNou.IdClient = ++nrClienti;

            //adaugare client in vectorul de obiecte
            adminClienti.AddClient(clientNou);

            MessageBox.Show("Clientul a fost adăugat cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNume.Clear();
            txtPrenume.Clear();
            txtCNP.Clear();
            txtNumar_Telefon.Clear();
            txtBuget.Clear();

            ClearErrors();
        }
        private void OnButtonClicked_Refresh(object sender, EventArgs e)
        {
            (new Form_Afisare_Client()).Show();
            this.Hide(); // Optionally hide this form
        }
        private void ShowError(Label label, string message)
        {
            label.ForeColor = System.Drawing.Color.Red; // Schimbare culoare text în roșu
            MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ClearErrors()
        {
            lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            lblPrenume.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCNP.ForeColor = System.Drawing.SystemColors.ControlText;
            lblNumar_Telefon.ForeColor = System.Drawing.SystemColors.ControlText;
            lblBuget.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
