

using Baralho;

namespace Forms_Jogo_21
{
    
    public partial class Form1 : Form
    {
        public Monte deck = new();
        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txb_Principal.Text = "Testando";


        }

        private void txb_Principal_TextChanged(object sender, EventArgs e)
        {

        }


    }
}