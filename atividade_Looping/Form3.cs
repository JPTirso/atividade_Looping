using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade_Looping
{
    public partial class FrmTemperatura : Form
    {
        public FrmTemperatura()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int F, C;
            lstGraus.Items.Clear();
            for (C = 10; C <= 100; C = C + 10)
            {
                F = (C * 9 / 5) + 32;
                lstGraus.Items.Add(C + "°C = " + F + "°F.");
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int F, C;
            C = 10;
            lstGraus.Items.Clear();
            do
            {
                F = (C * 9 / 5) + 32;
                lstGraus.Items.Add(C + "°C = " + F + "°F.");
                C = C + 10;
            }
            while (C <= 100);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int F, C;
            C = 10;
            lstGraus.Items.Clear();
            while (C <= 100)
            {
                F = (C * 9 / 5) + 32;
                lstGraus.Items.Add(C + "°C = " + F + "°F.");
                C = C + 10;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstGraus.Items.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
