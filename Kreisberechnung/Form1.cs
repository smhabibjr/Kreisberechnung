using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreisberechnung
{
    public partial class FRMkreis : Form
    {
        public FRMkreis()
        {
            InitializeComponent();
        }

        private void BTN_Rechnen_Click(object sender, EventArgs e)
        {
            // Initialisieren
            double A, u, r;

            // Eingabe
            r = Convert.ToDouble(TB_radius.Text);
  
            // Verarbeitung
            A = 3.14 * r * r;
            u = 2 * 3.14 * r;

            // Ausgabe
            TB_flaeche.Text = Convert.ToString(A);
            TB_umfang.Text = Convert.ToString(u);
        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            TB_flaeche.Text = "";
            TB_umfang.Text = "";
            TB_radius.Text = "";
            this.ActiveControl = TB_radius;
        }

        private void BTN_beenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
