using System;
using System.Collections;
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
using static LibrarieModele.Enumerari;

namespace InterfataUtilizator_WindowsForms
{
    public partial class Forma_Adauga_Produs : Form
    {
        IStocareData_Produs adminProduse;
        ArrayList optiuniSelectatate = new ArrayList();
        private const int ZERO = 0;
        public Forma_Adauga_Produs()
        {
            InitializeComponent();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (Validare() == true)
            {
                adminProduse = StocareFactory.GetAdministratorStocareProdus();

                List<Produs> produse = adminProduse.GetProduse();
                Produs.NextId = produse.Count;
                Produs produs=new Produs(txtNume.Text,Convert.ToInt32(txtCantitate.Text),Convert.ToSingle(txtPret.Text));

                produs.Tip_Produs = (TipProdus)Enum.Parse(typeof(TipProdus), cbxTip.SelectedItem.ToString()); 
                produs.Optiuni_Produs = new ArrayList();
                produs.Optiuni_Produs.AddRange(optiuniSelectatate);
                adminProduse.AddProdus(produs);
                MessageBox.Show("Produsul a fost adăugat cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetareCuloareErori();
                ResetareControale();

                this.Close();
            }
        }

        public void ResetareControale()
        {
            txtNume.Clear();
            txtPret.Clear();
            txtCantitate.Clear();
            cbxTip.SelectedIndex = -1;

            ckbBrand.Checked=false;
            ckbDisponibilFizic.Checked = false;
            ckbDisponibilOnline.Checked = false;
            ckbEditieLimitata.Checked = false;
            ckbGarantieExtinsa.Checked = false;
            ckbHandmade.Checked = false;
            ckbNedefinit.Checked = false;
            ckbNoName.Checked = false;
            ckbPersonalizabil.Checked = false;
            ckbPremium.Checked = false;
            ckbReciclabil.Checked = false;
            ckbReturUsor.Checked = false;
            ckbTravelSize.Checked = false;
            ckbVegan.Checked = false;
        }
        public void ResetareCuloareErori()
        {
            lblNume.ForeColor = System.Drawing.SystemColors.ControlText;
            lblCantitate.ForeColor = System.Drawing.SystemColors.ControlText;
            lblPret.ForeColor = System.Drawing.SystemColors.ControlText;
            lblTip.ForeColor = System.Drawing.SystemColors.ControlText;
            lblOptiuni.ForeColor = System.Drawing.SystemColors.ControlText;
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
            if (!int.TryParse(txtCantitate.Text, out int cantitate))
            {
                ShowError(lblPret, "Introduceți cantitatea");
                return false;
            }
            if (!float.TryParse(txtPret.Text, out float pret))
            {
                ShowError(lblPret, "Introduceți prețul");
                return false;
            }
            if (cbxTip.SelectedItem == null)
            {
                ShowError(lblTip, "Alegeti tipul de produs");
                return false;
            }
            if (optiuniSelectatate.Count == ZERO)
            {
                ShowError(lblOptiuni, "Alegeti optiunile pentru produs");
                return false;
            }
            return true;
        }
        private void CkbOptiuni_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 
            string optiuneselectata = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                optiuniSelectatate.Add(optiuneselectata);
            else
                optiuniSelectatate.Remove(optiuneselectata);
        }

    }
}

