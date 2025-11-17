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
    public partial class FrmTabuada : Form
    {
        public FrmTabuada()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txtNum.Text);

            if (num >= 1 && num <= 9)
            {
                lstTabuada.Items.Clear();
                for (i = 0; i <= 10; i++)
                {
                    result = num * i;
                    lstTabuada.Items.Add(num + " x " + i + " = " + result);
                }
            }
            else
            {
                MessageBox.Show("Insira um número entre 1 e 9.");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txtNum.Text);

            i = 0;

            if (num >= 1 && num <= 9)
            {
                lstTabuada.Items.Clear();
                while (i <= 10)
                {
                    result = num * i;
                    i++;
                    lstTabuada.Items.Add(num + " x " + i + " = " + result);
                }
            }

            else
            {
                MessageBox.Show("Insira um número entre 1 e 9.");
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num, result, i;

            num = Convert.ToInt32(txtNum.Text);

            i = 0;

            if (num >= 1 && num <= 9)
            {
                lstTabuada.Items.Clear();
                do
                {
                    result = num * i;
                    i++;
                    lstTabuada.Items.Add(num + " x " + i + " = " + result);
                }
                while (i <= 10);
            }

            else
            {
                MessageBox.Show("Insira um número entre 1 e 9.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            txtNum.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMenu menu = new FrmMenu();
            menu.Show();
        }
    }
}
