namespace atividadeMatriz
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void matrizAoQuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmMatriz1 Matriz1 = new FrmMatriz1();
            Matriz1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trocaDeSinaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTroca Troca = new FrmTroca();
            Troca.Show();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmComodo Comodo = new FrmComodo();
            Comodo.Show();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTemperatura Temperatura = new FrmTemperatura();
            Temperatura.Show();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmTabuada Tabuada = new FrmTabuada();
            Tabuada.Show();
        }

        private void matrizAoCuboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            FrmCubo Cubo = new FrmCubo();
            Cubo.Show();
        }
    }
}
