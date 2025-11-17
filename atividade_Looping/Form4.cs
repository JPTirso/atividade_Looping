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
    public partial class FrmComodo : Form
    {
        public FrmComodo()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double areaT, AreaC, comp, larg;
            int i, comodos;
            areaT = 0;
            comodos = Convert.ToInt32(txtComodo.Text);
            if (comodos > 0)
            {
                string[] larguras = txtLarg.Text.Split(';');
                string[] comprimentos = txtComp.Text.Split(';');

                if (larguras.Length != comodos || comprimentos.Length != comodos)
                {
                    MessageBox.Show("A quantidade de larguras e comprimentos deve ser igual à quantidade de cômodos.");
                    return;
                }
                txtAreaT.Clear();
                lstAreac.Items.Clear();
                for (i = 0; i < comodos; i++)
                {
                    larg = Convert.ToDouble(larguras[i]);
                    comp = Convert.ToDouble(comprimentos[i]);
                    AreaC = larg * comp;
                    areaT = AreaC + areaT;
                    lstAreac.Items.Add("Cômodo " + (i + 1) + " tem " + AreaC + "m²");
                }
                txtAreaT.Text = "A area total de sua casa é: " + areaT.ToString() + "m²";
            }
            else
            {
                MessageBox.Show("Insira um número válido de cômodos.");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double areaT, AreaC, comp, larg;
            int i, comodos;
            areaT = 0;
            i = 0;
            comodos = Convert.ToInt32(txtComodo.Text);
            if (comodos > 0)
            {
                string[] larguras = txtLarg.Text.Split(';');
                string[] comprimentos = txtComp.Text.Split(';');

                if (larguras.Length != comodos || comprimentos.Length != comodos)
                {
                    MessageBox.Show("A quantidade de larguras e comprimentos deve ser igual à quantidade de cômodos.");
                    return;
                }
                txtAreaT.Clear();
                lstAreac.Items.Clear();
                while (i < comodos)
                {
                    larg = Convert.ToDouble(larguras[i]);
                    comp = Convert.ToDouble(comprimentos[i]);
                    AreaC = larg * comp;
                    areaT = AreaC + areaT;
                    lstAreac.Items.Add("Cômodo " + (i + 1) + " tem " + AreaC + "m²");
                    i++;
                }
                txtAreaT.Text = "A area total de sua casa é: " + areaT.ToString() + "m²";
            }
            else
            {
                MessageBox.Show("Insira um número válido de cômodos.");
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            double areaT, AreaC, comp, larg;
            int i, comodos;
            areaT = 0;
            i = 0;
            comodos = Convert.ToInt32(txtComodo.Text);
            if (comodos > 0)
            {
                string[] larguras = txtLarg.Text.Split(';');
                string[] comprimentos = txtComp.Text.Split(';');

                if (larguras.Length != comodos || comprimentos.Length != comodos)
                {
                    MessageBox.Show("A quantidade de larguras e comprimentos deve ser igual à quantidade de cômodos.");
                    return;
                }
                txtAreaT.Clear();
                lstAreac.Items.Clear();
                do
                {
                    larg = Convert.ToDouble(larguras[i]);
                    comp = Convert.ToDouble(comprimentos[i]);
                    AreaC = larg * comp;
                    areaT = AreaC + areaT;
                    lstAreac.Items.Add("Cômodo " + (i + 1) + " tem " + AreaC + "m²");
                    i++;
                } while (i < comodos);
                txtAreaT.Text = "A area total de sua casa é: " + areaT.ToString() + "m²";
            }
            else
            {
                MessageBox.Show("Insira um número válido de cômodos.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAreaT.Clear();
            lstAreac.Items.Clear();
            txtComodo.Clear();
            txtLarg.Clear();
            txtComp.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
