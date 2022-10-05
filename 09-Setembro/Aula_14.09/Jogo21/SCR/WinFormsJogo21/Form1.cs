namespace WinFormsJogo21
{
    public partial class btnFinalizarRodada : Form
    {
        public int PontuaçãoJogador { get; set; }
        public int PontuaçãoPC { get; set; }

        public int SomaJogador { get; set; }
        public int SomaComputador { get; set; }
        public btnFinalizarRodada()
        {


            InitializeComponent();
        }

        private void BTNIniciar_Click(object sender, EventArgs e)
        {
            SomaComputador = 0;
            SomaJogador = 0;
            PontuaçãoJogador = 0;
            PontuaçãoPC = 0;
            txtPrincipal.Clear();
            btNovaCarta.Enabled = true;
            btPassarVez.Enabled = true;

            txbPlacarJogador.Text = PontuaçãoJogador.ToString();
            txbPlacarPC.Text = PontuaçãoPC.ToString();

            TBsomaJogador.Text = "Soma total: " + SomaJogador.ToString();
            TbsomaComputador.Text = "Soma total: " + SomaComputador.ToString();

            TBjogador.Clear();
            TBcomputador.Clear();

            //TBjogador.Clear();

            txtPrincipal.Text += "\r\nVez do jogador";
        }
        private void btNovaCarta_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int valor = rd.Next(1, 13);

            txtPrincipal.Text += "\r\nVocê tirou: " + valor + ".";
            txtPrincipal.Text += "\r\nMais uma carta ou passar a vez?";

            SomaJogador += valor;

            TBjogador.Text += valor + ", ";
            TBsomaJogador.Text = "Soma total: " + SomaJogador.ToString();

            if(SomaJogador > 21)
            {
                txtPrincipal.Text += "\r\n\r\nSua Passou de 21\r\n O Computador Venceu.";
                btNovaCarta.Enabled = false;
                btPassarVez.Enabled = false;
                PontuaçãoPC++;
                txbPlacarPC.Text = PontuaçãoPC.ToString();
            }
        }
        
        private void txbPlacarPC_TextChanged(object sender, EventArgs e)
        {

        }
        private void txbPlacarJogador_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void TBcomputador_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void TBjogador_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void TBsomaJogador_TextChanged(object sender, EventArgs e)
        {

        }


    }
}