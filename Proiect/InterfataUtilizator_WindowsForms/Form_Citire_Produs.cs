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
using static LibrarieModele.Enumerari;
using System.Text.RegularExpressions;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Form_Citire_Produs : Form
    {
        Administrare_FisierText_Produs adminProduse;
        public static int nrProduse = 0;

        private Label lblNume;
        private Label lblCantitate;
        private Label lblPret;
        private Label lblTip_Produs;
        private Label lblOptiuni_Produs;

        private TextBox txtNume;
        private TextBox txtCantitate;
        private TextBox txtPret;
        private ComboBox cbxTip_Produs;
        private CheckedListBox clbOptiuni_Produs;

        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;

        private Button btnAdd;
        private Button btnRefresh;
        private Button btnBack;

        public Form_Citire_Produs()
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
            this.Text = "Informatii produse";

            //adaugare control de tip Label pentru 'Nume';
            lblNume = new Label();
            lblNume.Width = LATIME_CONTROL;
            lblNume.Text = "Nume";
            lblNume.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(lblNume);


            //adaugare control de tip Label pentru 'Cantitate';
            lblCantitate = new Label();
            lblCantitate.Width = LATIME_CONTROL;
            lblCantitate.Text = "Cantitate";
            lblCantitate.Left = DIMENSIUNE_PAS_X;
            lblCantitate.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(lblCantitate);

            //adaugare control de tip Label pentru 'Pret';
            lblPret = new Label();
            lblPret.Width = LATIME_CONTROL;
            lblPret.Text = "Preț";
            lblPret.Left = DIMENSIUNE_PAS_X;
            lblPret.Top = DIMENSIUNE_PAS_Y * 2;
            this.Controls.Add(lblPret);

            //adaugare control de tip Label pentru 'Tip_Produs';
            lblTip_Produs = new Label();
            lblTip_Produs.Width = LATIME_CONTROL;
            lblTip_Produs.Text = "Tip produs";
            lblTip_Produs.Left = DIMENSIUNE_PAS_X;
            lblTip_Produs.Top = DIMENSIUNE_PAS_Y * 3;
            this.Controls.Add(lblTip_Produs);

            //adaugare control de tip Label pentru 'Optiuni_Produs';
            lblOptiuni_Produs = new Label();
            lblOptiuni_Produs.Width = LATIME_CONTROL;
            lblOptiuni_Produs.Text = "Opțiuni produs";
            lblOptiuni_Produs.Left = DIMENSIUNE_PAS_X;
            lblOptiuni_Produs.Top = DIMENSIUNE_PAS_Y * 4;
            this.Controls.Add(lblOptiuni_Produs);

            //adaugare control de tip Text pentru 'Nume';
            txtNume = new TextBox();
            txtNume.Width = 2 * LATIME_CONTROL;
            txtNume.Left = 2 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume);

            //adaugare control de tip Text pentru 'Cantitate';
            txtCantitate = new TextBox();
            txtCantitate.Width = 2 * LATIME_CONTROL;
            txtCantitate.Left = 2 * DIMENSIUNE_PAS_X;
            txtCantitate.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtCantitate);

            //adaugare control de tip Text pentru 'Pret';
            txtPret = new TextBox();
            txtPret.Width = 2 * LATIME_CONTROL;
            txtPret.Left = 2 * DIMENSIUNE_PAS_X;
            txtPret.Top = 2 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtPret);

            //adaugare control de tip ComboBox pentru 'Tip_Produs';
            cbxTip_Produs = new ComboBox(); 
            cbxTip_Produs.Left = 2 * DIMENSIUNE_PAS_X;
            cbxTip_Produs.Width = 2 * LATIME_CONTROL;
            cbxTip_Produs.Top = 3 * DIMENSIUNE_PAS_Y;
            cbxTip_Produs.BackColor = Color.White;
            cbxTip_Produs.DropDownStyle = ComboBoxStyle.DropDownList; 
            cbxTip_Produs.Items.AddRange(Enum.GetNames(typeof(Enumerari.TipProdus)));
            this.Controls.Add(cbxTip_Produs);

            //adaugare control de tip CheckedListBox pentru 'Optiuni_Produs';
            clbOptiuni_Produs = new CheckedListBox();
            clbOptiuni_Produs.Width = 2 * LATIME_CONTROL;
            clbOptiuni_Produs.Left = 2 * DIMENSIUNE_PAS_X;
            clbOptiuni_Produs.Top = 4 * DIMENSIUNE_PAS_Y;
            clbOptiuni_Produs.BackColor = Color.White;
            clbOptiuni_Produs.CheckOnClick = true;
            foreach(var optiune in Enum.GetValues(typeof(OptiuniProdus)))
                clbOptiuni_Produs.Items.Add(optiune.ToString());
            this.Controls.Add(clbOptiuni_Produs);

            //adaugare control de tip Button pentru Adauga
            btnAdd = new Button();
            btnAdd.Width = LATIME_CONTROL;
            btnAdd.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 7 * DIMENSIUNE_PAS_Y);
            btnAdd.BackColor = Color.White;
            btnAdd.Text = "Adauga";
            btnAdd.Click += OnButtonClicked_Add;
            this.Controls.Add(btnAdd);

            //adaugare control de tip Button pentru Refresh
            btnRefresh = new Button();
            btnRefresh.Width = LATIME_CONTROL;
            btnRefresh.Location = new System.Drawing.Point(2 * DIMENSIUNE_PAS_X, 7 * DIMENSIUNE_PAS_Y);
            btnRefresh.BackColor = Color.White;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += OnButtonClicked_Refresh;
            this.Controls.Add(btnRefresh);

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
        }

        private void OnButtonClicked_Add(object sender, EventArgs e)
        {
            // obiectul *sender* este butonul btnCalculeaza
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button
            // catre subscriber-ul curent care este forma FormularGeometrie 

            string Nume = txtNume.Text;
            string Cantitate = txtCantitate.Text;
            string Pret = txtPret.Text;
            OptiuniProdus Optiuni = OptiuniProdus.Nedefinit;

            foreach (var optiune in clbOptiuni_Produs.CheckedItems)
                Optiuni |= (OptiuniProdus)Enum.Parse(typeof(OptiuniProdus), optiune.ToString());

            if (string.IsNullOrWhiteSpace(Nume.ToString()))
            {
                ShowError(lblNume, "Introduceti numele");
                return;
            }

            if (!int.TryParse(Cantitate, out int cantitate))
            {
                ShowError(lblCantitate, "Introduceti cantitatea");
                return;
            }

            if (!float.TryParse(Pret, out float pret))
            {
                ShowError(lblPret, "Introduceti pretul");
                return;
            }

            if (cbxTip_Produs.SelectedItem==null)
            {
                ShowError(lblTip_Produs, "Alegeti tipul de produs");
                return;
            }

            if (clbOptiuni_Produs.SelectedItem==null)
            {
                ShowError(lblOptiuni_Produs, "Alegeti optiunile pentru produs");
                return;
            }


            string numeFisier = ConfigurationManager.AppSettings["NumeFisierProdus"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminProduse = new Administrare_FisierText_Produs(caleCompletaFisier);

            Produs[] produse = adminProduse.GetProduse(out nrProduse);
            Produs produsNou = new Produs(Nume, int.Parse(Cantitate), float.Parse(Pret));
            produsNou.IdProdus = ++nrProduse;

            produsNou.Tip_Produs = (TipProdus)Enum.Parse(typeof(TipProdus), cbxTip_Produs.SelectedItem.ToString());
            produsNou.Optiuni_Produs = Optiuni;

            //adaugare produs in vectorul de obiecte
            adminProduse.AddProdus(produsNou);

            MessageBox.Show("Produsul a fost adăugat cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNume.Clear();
            txtCantitate.Clear();
            txtPret.Clear();
            cbxTip_Produs.SelectedIndex = -1;
            for (int i = 0; i < clbOptiuni_Produs.Items.Count; i++)
                clbOptiuni_Produs.SetItemChecked(i, false);
           
            ClearErrors();
        }
        private void OnButtonClicked_Refresh(object sender, EventArgs e)
        {
            (new Form_Afisare_Produs()).Show();
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
            lblCantitate.ForeColor = System.Drawing.SystemColors.ControlText;
            lblPret.ForeColor = System.Drawing.SystemColors.ControlText;
            lblTip_Produs.ForeColor = System.Drawing.SystemColors.ControlText;
            lblOptiuni_Produs.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OnButtonClicked_Back(object sender, EventArgs e)
        {
            (new Main()).Show();
            this.Hide(); // Optionally hide this form
        }
    }
}
