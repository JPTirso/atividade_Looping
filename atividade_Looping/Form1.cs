namespace atividade_Looping
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTabuada tabuada = new FrmTabuada();
            tabuada.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTemperatura temperatura = new FrmTemperatura();
            temperatura.Show();
        }
    }
}
