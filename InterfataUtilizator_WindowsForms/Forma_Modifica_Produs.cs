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
    public partial class Forma_Modifica_Produs : Form
    {
        IStocareData_Produs adminProduse;
        ArrayList optiuniSelectatate = new ArrayList();
        private const int ZERO = 0;
        public static int ID;
        public Forma_Modifica_Produs(int id)
        {
            InitializeComponent();
            ID = id;
            adminProduse = StocareFactory.GetAdministratorStocareProdus();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (Validare() == true)
            {
                adminProduse = StocareFactory.GetAdministratorStocareProdus();

                Produs produs_nemodificat = adminProduse.GetProdustbyIndex(ID);
                Produs produs = new Produs(txtNume.Text, Convert.ToInt32(txtCantitate.Text), Convert.ToSingle(txtPret.Text));
                produs.IdProdus = ID;
                produs.Tip_Produs = (TipProdus)Enum.Parse(typeof(TipProdus), cbxTip.SelectedItem.ToString());
                produs.Optiuni_Produs = new ArrayList();
                produs.Optiuni_Produs.AddRange(optiuniSelectatate);

                if (adminProduse.UpdateProdus(produs) == true)
                {
                    MessageBox.Show("Produsul a fost modificat cu succes în fișier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }
        public void SetareControale(Produs produs)
        {
            txtNume.Text = produs.Nume;
            txtCantitate.Text = produs.Cantitate.ToString();
            txtPret.Text = produs.Pret.ToString();

            cbxTip.Text = produs.Tip_Produs.ToString();

            ckbBrand.Checked = produs.Optiuni_Produs.Contains(ckbBrand.Text);
            ckbDisponibilFizic.Checked = produs.Optiuni_Produs.Contains(ckbDisponibilFizic.Text);
            ckbDisponibilOnline.Checked = produs.Optiuni_Produs.Contains(ckbDisponibilOnline.Text);
            ckbEditieLimitata.Checked = produs.Optiuni_Produs.Contains(ckbEditieLimitata.Text);
            ckbGarantieExtinsa.Checked = produs.Optiuni_Produs.Contains(ckbGarantieExtinsa.Text);
            ckbHandmade.Checked = produs.Optiuni_Produs.Contains(ckbHandmade.Text);
            ckbNedefinit.Checked = produs.Optiuni_Produs.Contains(ckbNedefinit.Text);
            ckbNoName.Checked = produs.Optiuni_Produs.Contains(ckbNoName.Text);
            ckbPersonalizabil.Checked = produs.Optiuni_Produs.Contains(ckbPersonalizabil.Text);
            ckbPremium.Checked = produs.Optiuni_Produs.Contains(ckbPremium.Text);
            ckbReciclabil.Checked = produs.Optiuni_Produs.Contains(ckbReciclabil.Text);
            ckbReturUsor.Checked = produs.Optiuni_Produs.Contains(ckbReturUsor.Text);
            ckbTravelSize.Checked = produs.Optiuni_Produs.Contains(ckbTravelSize.Text);
            ckbVegan.Checked = produs.Optiuni_Produs.Contains(ckbVegan.Text);

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


