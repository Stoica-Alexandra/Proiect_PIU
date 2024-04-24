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
    public partial class Form_Afisare_Produs : Form
    {
        Administrare_FisierText_Produs adminProduse;

        private Label lblId_Produs;
        private Label lblNume;
        private Label lblCantitate;
        private Label lblPret;
        private Label lblTip_Produs;
        private Label lblOptiuni_Produs;

        private Label[,] lblProduse;

        private Button btnBack;

        private const int NR_LABEL = 6;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form_Afisare_Produs()
        {
            InitializeComponent();

            string numeFisier = ConfigurationManager.AppSettings["NumeFisierProdus"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminProduse = new Administrare_FisierText_Produs(caleCompletaFisier);
            int nrProduse = 0;

            Produs[] produse = adminProduse.GetProduse(out nrProduse);

            //setare proprietati
            //this.AutoSize = true;
            this.Size = new Size(700, 400);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.BackColor = Color.Lavender;
            this.Text = "Informatii produse";

            //adaugare control de tip Label pentru 'Id_Produs';
            lblId_Produs = new Label();
            lblId_Produs.Width = LATIME_CONTROL / 4;
            lblId_Produs.Text = "ID";
            lblId_Produs.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(lblId_Produs);

            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = 3 * LATIME_CONTROL / 4;
            lblNume.Text = "Nume";
            lblNume.Left = 4 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblNume);

            //adaugare control de tip Label pentru 'Cantitate';
            lblCantitate = new Label();
            lblCantitate.Width = 3 * LATIME_CONTROL / 4;
            lblCantitate.Text = "Cantitate";
            lblCantitate.Left = 7 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblCantitate);

            //adaugare control de tip Label pentru 'Pret';
            lblPret = new Label();
            lblPret.Width = LATIME_CONTROL;
            lblPret.Text = "Preț";
            lblPret.Left = 10 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblPret);

            //adaugare control de tip Label pentru 'Tip_Produs';
            lblTip_Produs = new Label();
            lblTip_Produs.Width = 6 * LATIME_CONTROL / 5;
            lblTip_Produs.Text = "Tip produs";
            lblTip_Produs.Left = 13 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblTip_Produs);

            //adaugare control de tip Label pentru 'Optiuni_Produs';
            lblOptiuni_Produs = new Label();
            lblOptiuni_Produs.Width = LATIME_CONTROL;
            lblOptiuni_Produs.Text = "Opțiuni produs";
            lblOptiuni_Produs.Left = 16 * DIMENSIUNE_PAS_X / 3;
            this.Controls.Add(lblOptiuni_Produs);

            //adaugare control de tip Button pentru Inapoi
            btnBack = new Button();
            btnBack.Width = LATIME_CONTROL / 2;
            btnBack.Location = new System.Drawing.Point(10, 0);
            btnBack.BackColor = Color.White;
            btnBack.Text = "Back";
            btnBack.Click += OnButtonClicked_Back;
            this.Controls.Add(btnBack);

            // adaugare handlere pentru evenimentele FormClosed ale formei
            this.FormClosed += OnFormClosed;
            AfiseazaProduse();
        }

        private void AfiseazaProduse()
        {
            Produs[] produse = adminProduse.GetProduse(out int nrProduse);
            lblProduse = new Label[nrProduse, NR_LABEL];

            int i = 0;
            foreach (Produs produs in produse)
                if (produs != null)
                {
                    //adaugare control de tip Label pentru id-ul produselor;
                    lblProduse[i, 0] = new Label();
                    lblProduse[i, 0].Width = LATIME_CONTROL / 4;
                    lblProduse[i, 0].Text = produs.IdProdus.ToString();
                    lblProduse[i, 0].Left = DIMENSIUNE_PAS_X;
                    lblProduse[i, 0].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                    this.Controls.Add(lblProduse[i, 0]);

                    //adaugare control de tip Label pentru numele produselor;
                    lblProduse[i, 1] = new Label();
                    lblProduse[i, 1].Width = 3 * LATIME_CONTROL / 4;
                    lblProduse[i, 1].Text = produs.Nume;
                    lblProduse[i, 1].Left = 4 * DIMENSIUNE_PAS_X / 3;
                    lblProduse[i, 1].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                    this.Controls.Add(lblProduse[i, 1]);

                    //adaugare control de tip Label pentru cantiatea produselor;
                    lblProduse[i, 2] = new Label();
                    lblProduse[i, 2].Width = 3 * LATIME_CONTROL / 4;
                    lblProduse[i, 2].Text = produs.Cantitate.ToString();
                    lblProduse[i, 2].Left = 7 * DIMENSIUNE_PAS_X / 3;
                    lblProduse[i, 2].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                    this.Controls.Add(lblProduse[i, 2]);

                    //adaugare control de tip Label pentru pretul produselor;
                    lblProduse[i, 3] = new Label();
                    lblProduse[i, 3].Width = LATIME_CONTROL;
                    lblProduse[i, 3].Text = string.Join(" ",produs.Pret.ToString(),"lei");
                    lblProduse[i, 3].Left = 10 * DIMENSIUNE_PAS_X / 3;
                    lblProduse[i, 3].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                    this.Controls.Add(lblProduse[i, 3]);

                    //adaugare control de tip Label pentru tipul produselor;
                    lblProduse[i, 4] = new Label();
                    lblProduse[i, 4].Width = LATIME_CONTROL;
                    lblProduse[i, 4].Text = produs.Tip_Produs.ToString();
                    lblProduse[i, 4].Left = 13 * DIMENSIUNE_PAS_X / 3;
                    lblProduse[i, 4].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                    this.Controls.Add(lblProduse[i, 4]);

                    //adaugare control de tip Label pentru optiunile produselor;
                    lblProduse[i, 5] = new Label();
                    lblProduse[i, 5].Width = 6*LATIME_CONTROL;
                    lblProduse[i, 5].Text = produs.Optiuni_Produs.ToString();
                    lblProduse[i, 5].Left = 16 * DIMENSIUNE_PAS_X / 3;
                    lblProduse[i, 5].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                    this.Controls.Add(lblProduse[i, 5]);

                    i++;
                }
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnButtonClicked_Back(object sender, EventArgs e)
        {
            (new Form_Citire_Produs()).Show();
            this.Hide(); // Optionally hide this form
        }
    }

}
