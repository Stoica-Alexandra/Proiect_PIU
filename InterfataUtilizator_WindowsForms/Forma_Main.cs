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
    public partial class Forma_Main : Form
    {
        public Forma_Main()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            (new Forma_Afisare_Client()).Show();
            this.Hide();
        }

        private void btnProdus_Click(object sender, EventArgs e)
        {
            (new Forma_Afisare_Produs()).Show();
            this.Hide();
        }
    }
}
