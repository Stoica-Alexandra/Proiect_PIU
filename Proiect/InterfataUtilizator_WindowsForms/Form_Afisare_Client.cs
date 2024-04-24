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
    public partial class Form_Afisare_Client : Form
    {
        Administrare_FisierText_Client adminClienti;

        private Label lblID_Client;
        private Label lblNume;
        private Label lblPrenume;
        private Label lblCNP;
        private Label lblNumar_Telefon;
        private Label lblBuget;

        private Label[,] lblClienti;

        private Button btnBack;

        private const int NR_LABEL =6 ;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form_Afisare_Client()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisierClient"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            adminClienti = new Administrare_FisierText_Client(caleCompletaFisier);
            int nrClienti = 0;

            Client[] clienti = adminClienti.GetClienti(out nrClienti);

            //setare proprietati
            //this.AutoSize = true;
            this.Size = new Size(700,400);
            this.AutoSizeMode=AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.BackColor = Color.Lavender;
            this.Text = "Informatii clienti";

            //adaugare control de tip Label pentru 'ID_Client';
            lblID_Client = new Label();
            lblID_Client.Width = LATIME_CONTROL/4;
            lblID_Client.Text = "ID";
            lblID_Client.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(lblID_Client);

            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width =3* LATIME_CONTROL/4;
            lblNume.Text = "Nume";
            lblNume.Left = 4 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblNume);

            //adaugare control de tip Label pentru 'Prenume';
            lblPrenume = new Label();
            lblPrenume.Width = 3*LATIME_CONTROL/4;
            lblPrenume.Text = "Prenume";
            lblPrenume.Left = 7 * DIMENSIUNE_PAS_X/3;
            this.Controls.Add(lblPrenume);

            //adaugare control de tip Label pentru 'CNP';
            lblCNP = new Label();
            lblCNP.Width = LATIME_CONTROL;
            lblCNP.Text = "CNP";
            lblCNP.Left = 10 * DIMENSIUNE_PAS_X/3;
            this.Controls.Add(lblCNP);

            //adaugare control de tip Label pentru 'Numar_Telefon';
            lblNumar_Telefon = new Label();
            lblNumar_Telefon.Width = 6 * LATIME_CONTROL/5;
            lblNumar_Telefon.Text = "Număr de telefon";
            lblNumar_Telefon.Left = 13 * DIMENSIUNE_PAS_X/3;
            this.Controls.Add(lblNumar_Telefon);

            //adaugare control de tip Label pentru 'Buget';
            lblBuget = new Label();
            lblBuget.Width = LATIME_CONTROL;
            lblBuget.Text = "Buget";
            lblBuget.Left = 16 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblBuget);

            //adaugare control de tip Button pentru Inapoi
            btnBack = new Button();
            btnBack.Width = LATIME_CONTROL/2;
            btnBack.Location = new System.Drawing.Point(10, 0);
            btnBack.BackColor = Color.White;
            btnBack.Text = "Back";
            btnBack.Click += OnButtonClicked_Back;
            this.Controls.Add(btnBack);

            // adaugare handlere pentru evenimentele FormClosed ale formei
            this.FormClosed += OnFormClosed;
            AfiseazaClienti();
        }

        private void AfiseazaClienti()
        {
            Client[] clienti = adminClienti.GetClienti(out int nrClienti);
            lblClienti = new Label[nrClienti,NR_LABEL];

            int i = 0;
            foreach (Client client in clienti)
            if(client!=null)
            {
                //adaugare control de tip Label pentru id-ul clientilor;
                lblClienti[i,0] = new Label();
                lblClienti[i,0].Width = LATIME_CONTROL/4;
                lblClienti[i,0].Text = client.IdClient.ToString();
                lblClienti[i,0].Left = DIMENSIUNE_PAS_X;
                lblClienti[i,0].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblClienti[i,0]);

                //adaugare control de tip Label pentru numele clientilor;
                lblClienti[i, 1] = new Label();
                lblClienti[i, 1].Width = 3*LATIME_CONTROL/4;
                lblClienti[i, 1].Text = client.Nume;
                lblClienti[i, 1].Left = 4 * DIMENSIUNE_PAS_X/3;
                lblClienti[i, 1].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblClienti[i, 1]);

                //adaugare control de tip Label pentru prenumele clientilor
                lblClienti[i, 2] = new Label();
                lblClienti[i, 2].Width = 3*LATIME_CONTROL/4;
                lblClienti[i, 2].Text = client.Prenume;
                lblClienti[i, 2].Left = 7 * DIMENSIUNE_PAS_X/3;
                lblClienti[i, 2].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblClienti[i, 2]);

                //adaugare control de tip Label pentru CNP-ul clientilor;
                lblClienti[i, 3] = new Label();
                lblClienti[i, 3].Width = LATIME_CONTROL;
                lblClienti[i, 3].Text = client.CNP;
                lblClienti[i, 3].Left = 10 * DIMENSIUNE_PAS_X/3;
                lblClienti[i, 3].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblClienti[i, 3]);

                //adaugare control de tip Label pentru numarul de telefon clientilor;
                lblClienti[i, 4] = new Label();
                lblClienti[i, 4].Width = LATIME_CONTROL;
                lblClienti[i, 4].Text = client.NrTelefon;
                lblClienti[i, 4].Left = 13 * DIMENSIUNE_PAS_X/3;
                lblClienti[i, 4].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblClienti[i, 4]);

                //adaugare control de tip Label pentru bugetul clientilor
                lblClienti[i, 5] = new Label();
                lblClienti[i, 5].Width = LATIME_CONTROL;
                lblClienti[i, 5].Text = string.Join(" ",client.Buget.ToString(),"lei");
                lblClienti[i, 5].Left = 16*DIMENSIUNE_PAS_X/3;
                lblClienti[i, 5].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblClienti[i, 5]);

                i++;
            }
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnButtonClicked_Back(object sender, EventArgs e)
        {
            (new Form_Citire_Client()).Show();
            this.Hide(); // Optionally hide this form
        }
    }
    
}
