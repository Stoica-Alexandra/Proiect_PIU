using LibrarieModele;
using NivelStocareDate;
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

    public partial class Main : Form
    {
        private Button btnProdus;
        private Button btnClient;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

        public Main()
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
            this.Text = "Main";

            //adaugare control de tip Button pentru Produs
            btnProdus = new Button();
            btnProdus.Width = LATIME_CONTROL;
            btnProdus.Location = new System.Drawing.Point(9*DIMENSIUNE_PAS_X/4, 6 * DIMENSIUNE_PAS_Y);
            btnProdus.BackColor = Color.White;
            btnProdus.Text = "Produs";
            btnProdus.Click += OnButtonClicked_Produs;
            this.Controls.Add(btnProdus);

            //adaugare control de tip Button pentru Client
            btnClient = new Button();
            btnClient.Width = LATIME_CONTROL;
            btnClient.Location = new System.Drawing.Point(13*DIMENSIUNE_PAS_X/4, 6 * DIMENSIUNE_PAS_Y);
            btnClient.BackColor = Color.White;
            btnClient.Text = "Client";
            btnClient.Click += OnButtonClicked_Client;
            this.Controls.Add(btnClient);

            // adaugare handlere pentru evenimentele FormClosed ale formei
            this.FormClosed += OnFormClosed;
        } 
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnButtonClicked_Produs(object sender, EventArgs e)
        {
            (new Form_Citire_Produs()).Show();
            this.Hide(); // Optionally hide this form
        }
        private void OnButtonClicked_Client(object sender, EventArgs e)
        {
            (new Form_Citire_Client()).Show();
            this.Hide(); // Optionally hide this form
        }
    }
}

